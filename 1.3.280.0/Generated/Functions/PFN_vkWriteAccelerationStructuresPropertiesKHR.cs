using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkWriteAccelerationStructuresPropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, ulong, void*, ulong, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, ulong, void*, ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkWriteAccelerationStructuresPropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, ulong, void*, ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkWriteAccelerationStructuresPropertiesKHR(delegate *unmanaged[Cdecl]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, ulong, void*, ulong, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkWriteAccelerationStructuresPropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkWriteAccelerationStructuresPropertiesKHR(VkFunctionPointer v) => new PFN_vkWriteAccelerationStructuresPropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkWriteAccelerationStructuresPropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkWriteAccelerationStructuresPropertiesKHR(void* v) => new PFN_vkWriteAccelerationStructuresPropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, ulong dataSize, void* pData, ulong stride)
        {
            return this.ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
    }
}
