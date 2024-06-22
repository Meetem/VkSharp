using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetAccelerationStructureHandleNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, ulong, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureHandleNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureHandleNV(delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetAccelerationStructureHandleNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureHandleNV(VkFunctionPointer v) => new PFN_vkGetAccelerationStructureHandleNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetAccelerationStructureHandleNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureHandleNV(void* v) => new PFN_vkGetAccelerationStructureHandleNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkAccelerationStructureNV accelerationStructure, ulong dataSize, void* pData)
        {
            return this.ptr(device, accelerationStructure, dataSize, pData);
        }
    }
}
