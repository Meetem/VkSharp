using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkReallocationFunction : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<void*, void*, ulong, ulong, VkSystemAllocationScope, void*> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<void*, void*, ulong, ulong, VkSystemAllocationScope, void*>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkReallocationFunction(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<void*, void*, ulong, ulong, VkSystemAllocationScope, void*>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkReallocationFunction(delegate *unmanaged[Cdecl]<void*, void*, ulong, ulong, VkSystemAllocationScope, void*> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkReallocationFunction v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkReallocationFunction(VkFunctionPointer v) => new PFN_vkReallocationFunction(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkReallocationFunction v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkReallocationFunction(void* v) => new PFN_vkReallocationFunction(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void* Call(void* pUserData, void* pOriginal, ulong size, ulong alignment, VkSystemAllocationScope allocationScope)
        {
            return this.ptr(pUserData, pOriginal, size, alignment, allocationScope);
        }
    }
}
