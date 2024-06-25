using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(VkFunctionPointer v) => new PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(void* v) => new PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures)
        {
            this.ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
        }
    }
}
