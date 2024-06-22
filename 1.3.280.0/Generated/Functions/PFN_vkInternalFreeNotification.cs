using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkInternalFreeNotification : IVkFuncPtr
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
        public PFN_vkInternalFreeNotification(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkInternalFreeNotification(delegate *unmanaged[Cdecl]<void*, ulong, VkInternalAllocationType, VkSystemAllocationScope, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkInternalFreeNotification v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInternalFreeNotification(VkFunctionPointer v) => new PFN_vkInternalFreeNotification(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkInternalFreeNotification v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInternalFreeNotification(void* v) => new PFN_vkInternalFreeNotification(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(void* pUserData, ulong size, VkInternalAllocationType allocationType, VkSystemAllocationScope allocationScope)
        {
            this.ptr(pUserData, size, allocationType, allocationScope);
        }
    }
}
