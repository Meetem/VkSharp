using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkAllocationFunction : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<void*, ulong, ulong, VkSystemAllocationScope, void*> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<void*, ulong, ulong, VkSystemAllocationScope, void*>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocationFunction(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<void*, ulong, ulong, VkSystemAllocationScope, void*>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocationFunction(delegate *unmanaged[Cdecl]<void*, ulong, ulong, VkSystemAllocationScope, void*> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkAllocationFunction v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocationFunction(VkFunctionPointer v) => new PFN_vkAllocationFunction(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkAllocationFunction v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocationFunction(void* v) => new PFN_vkAllocationFunction(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void* Call(void* pUserData, ulong size, ulong alignment, VkSystemAllocationScope allocationScope)
        {
            return this.ptr(pUserData, size, alignment, allocationScope);
        }
    }
}
