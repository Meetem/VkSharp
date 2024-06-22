﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
#if UNITY_2019_1_OR_NEWER
using Unity.Burst;
#endif

namespace VkSharp
{
    public class VkLoader
    {
        /// <summary>
        /// Why is that?
        /// The trick here is to utilize .DAT memory storage in Burst
        ///
        /// If we use SharedStatic<> then data is properly shared between Burst and managed,
        /// but at a cost of having additional indirect on access.
        /// Instead of that, we can make static readonly array field which will be directly
        /// embedded into a data section of the native library saving one indirect.
        ///
        /// But it also requires additional care to synchronize .NET and Burst side. 
        /// </summary>
        private static readonly ulong[] allFunctions = new ulong[VkFunctions.Capacity];

        private static Dictionary<string, int> functionIdMapping = new Dictionary<string, int>();

        [ThreadStatic]
        private static byte[] tempString;
        
        public static ref VkFunctions GetFunctions()
        {
            unsafe
            {
                return ref VkUnsafe.PtrToRef<VkFunctions>(VkUnsafe.RefToPtr(ref allFunctions[0]));
            }
        }

        public static VkFunctionPointer LoadInstanceFunction(VkInstance instance, string name)
        {
            unsafe
            {
                VkFunctionPointer procAddr = default;
                if (!functionIdMapping.TryGetValue(name, out var mappedId))
                    mappedId = -1;
                
                if (mappedId != -1)
                {
                    procAddr = new VkFunctionPointer(GetFunction(mappedId));
                    if (procAddr.Pointer != null)
                        return procAddr;
                }

                if (tempString == null)
                {
                    tempString = new byte[2048];
                    tempString[0] = 0;
                }

                var numBytes = Encoding.ASCII.GetBytes(name, 0, name.Length, tempString, 0);
                tempString[numBytes] = 0;

                fixed (byte* b = tempString)
                {
                    procAddr = GetFunctions().vkGetInstanceProcAddr.Call(instance, b);
                }

                if (procAddr.Pointer != null)
                {
                    if (mappedId != -1)
                    {
                        SetFunction(mappedId, procAddr);
                        UpdatePointersSingleValueInBurst(mappedId);
                    }
                }

                return procAddr;
            }
        }

        public static VkFunctionPointer LoadDeviceFunction(VkDevice device, string name)
        {
            unsafe
            {
                VkFunctionPointer procAddr = default;
                if (!functionIdMapping.TryGetValue(name, out var mappedId))
                    mappedId = -1;
                
                if (mappedId != -1)
                {
                    procAddr = new VkFunctionPointer(GetFunction(mappedId));
                    if (procAddr.Pointer != null)
                        return procAddr;
                }

                if (tempString == null)
                {
                    tempString = new byte[2048];
                    tempString[0] = 0;
                }

                var numBytes = Encoding.ASCII.GetBytes(name, 0, name.Length, tempString, 0);
                tempString[numBytes] = 0;

                fixed (byte* b = tempString)
                {
                    procAddr = GetFunctions().vkGetDeviceProcAddr.Call(device, b);
                }

                if (procAddr.Pointer != null)
                {
                    if (mappedId != -1)
                    {
                        SetFunction(mappedId, procAddr);
                        UpdatePointersSingleValueInBurst(mappedId);
                    }
                }

                return procAddr;
            }
        }
        
        public static T LoadDeviceFunction<T>(VkDevice device)
            where T: unmanaged, IVkFuncPtr
        {
            unsafe
            {
                var name = typeof(T).Name.Substring(4);
                var ptr = LoadDeviceFunction(device, name);
                return *(T*)&ptr;
            }
        }
        
        public static T LoadInstanceFunction<T>(VkInstance instance)
            where T: unmanaged, IVkFuncPtr
        {
            unsafe
            {
                var name = typeof(T).Name.Substring(4);
                var ptr = LoadInstanceFunction(instance, name);
                return *(T*)&ptr;
            }
        }

        private static void MakeFunctionMapping()
        {
            foreach (var field in typeof(VkFunctions).GetFields(BindingFlags.Public))
            {
                var idAttribute = field.GetCustomAttribute<VkFunctionIdAttribute>();
                if (idAttribute == null)
                    return;

                var id = idAttribute.Id;
                var funcName = field.Name;
                if (funcName.StartsWith("PFN_aux", StringComparison.Ordinal))
                    continue;

                functionIdMapping[funcName] = id;
            }
        }

#if UNITY_2019_1_OR_NEWER
        public static unsafe ulong* BurstFunctionsAddresses = null;
        
        [BurstDiscard]
        private static void SetManaged(ref int isManaged){
            isManaged = 1;
        }
        
        private static bool IsManaged()
        {
            int isManaged = 0;
            SetManaged(ref isManaged);
            return isManaged > 0;
        }

        public static unsafe void Initialize(PFN_vkGetInstanceProcAddr instance, PFN_vkGetDeviceProcAddr device)
        {
            if(!IsManaged())
                throw new InvalidOperationException($"Initialize cannot be called from Burst");
            
            InitializeBurst();
            SetFunction(VkFunctions.vkGetDeviceProcAddrId, device);
            SetFunction(VkFunctions.vkGetInstanceProcAddrId, instance);
            MakeFunctionMapping();
            
            UpdatePointersInBurst();
        }

        [BurstCompile]
        private static unsafe void RetriveBurstPointer(ref ulong *writePointerTo)
        {
            #if ENABLE_BURST_AOT
            int isManaged = 0;
            SetManaged(ref isManaged);
            if(isManaged > 0)
                throw new InvalidOperationException("Managed version of the function is called");
            #endif
            
            writePointerTo = VkUnsafe.RefToPtr(ref allFunctions[0]);
        }
        
        [BurstDiscard]
        public static unsafe void InitializeBurst()
        {
            RetriveBurstPointer(ref BurstFunctionsAddresses);
        }
        
        [BurstDiscard]
        public static unsafe void UpdatePointersInBurst()
        {
#if ENABLE_BURST_AOT
            if(!IsManaged())
                throw new InvalidOperationException("UpdatePointersInBurst cannot be called from Burst");
#endif
            
            if(BurstFunctionsAddresses == null){
                InitializeBurst();
            }

            var managed = GetFunctionsStorageManaged();
            for(int i = 0;i<VkFunctions.Capacity;i++){
                BurstFunctionsAddresses[i] = managed[i];
            }
        }

        [BurstDiscard]
        private static unsafe void UpdatePointersSingleValueInBurst(int id)
        {
#if ENABLE_BURST_AOT
            if(!IsManaged())
                throw new InvalidOperationException("UpdatePointersInBurst cannot be called from Burst");
#endif

            if(BurstFunctionsAddresses == null){
                InitializeBurst();
            }

            if (id < 0 || id >= VkFunctions.Capacity)
                return;

            var managed = GetFunctionsStorageManaged();
            BurstFunctionsAddresses[id] = managed[id];
        }

        public static unsafe ulong* GetFunctionsStorageManaged()
        {
            if(!IsManaged())
                throw new InvalidOperationException("Burst version of the function is called");

            return VkUnsafe.RefToPtr(ref allFunctions[0]);
        }

        [BurstCompile]
        public static unsafe ulong* GetFunctionsStorageBurst()
        {
            if(IsManaged())
                throw new InvalidOperationException("Managed version of the function is called");

            return VkUnsafe.RefToPtr(ref allFunctions[0]);
        }
#else
        // No-op
        public static unsafe void UpdatePointersInBurst()
        {
        }

        // No-op
        private static unsafe void UpdatePointersSingleValueInBurst(int id)
        {
            
        }
        
        public static unsafe void Initialize(PFN_vkGetInstanceProcAddr instance, PFN_vkGetDeviceProcAddr device)
        {
            SetFunction(VkFunctions.vkGetDeviceProcAddrId, device);
            SetFunction(VkFunctions.vkGetInstanceProcAddrId, instance);
            MakeFunctionMapping();
        }

        public static unsafe ulong* GetFunctionsStorageManaged()
        {
            return VkUnsafe.RefToPtr(ref allFunctions[0]);
        }
#endif
        
        public static unsafe void* GetFunction(int id)
        {
            ref var f = ref allFunctions[0];
            var functions = (ulong*)VkUnsafe.RefToPtr(ref f);
            return (void*)functions[id];
        }

        public static unsafe void SetFunction(int id, void* ptr)
        {
            ref var f = ref allFunctions[0];
            var functions = (ulong*)VkUnsafe.RefToPtr(ref f);
            functions[id] = (ulong)ptr;
        }
    }
}