using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkBindAccelerationStructureMemoryNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBindAccelerationStructureMemoryNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBindAccelerationStructureMemoryNV(delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkBindAccelerationStructureMemoryNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBindAccelerationStructureMemoryNV(VkFunctionPointer v) => new PFN_vkBindAccelerationStructureMemoryNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkBindAccelerationStructureMemoryNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBindAccelerationStructureMemoryNV(void* v) => new PFN_vkBindAccelerationStructureMemoryNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            return this.ptr(device, bindInfoCount, pBindInfos);
        }
    }
}
