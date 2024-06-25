using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkInternalAllocationNotification : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkInternalAllocationNotification(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkInternalAllocationNotification(delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkInternalAllocationNotification v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInternalAllocationNotification(VkFunctionPointer v) => new PFN_vkInternalAllocationNotification(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkInternalAllocationNotification v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInternalAllocationNotification(void* v) => new PFN_vkInternalAllocationNotification(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(void* pUserData, ulong size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope)
        {
            this.ptr(pUserData, size, allocationType, allocationScope);
        }
    }
}
