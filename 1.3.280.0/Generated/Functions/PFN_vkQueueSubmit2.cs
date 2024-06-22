using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueSubmit2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueSubmit2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueSubmit2(delegate *unmanaged[Cdecl]<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueSubmit2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueSubmit2(VkFunctionPointer v) => new PFN_vkQueueSubmit2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueSubmit2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueSubmit2(void* v) => new PFN_vkQueueSubmit2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return this.ptr(queue, submitCount, pSubmits, fence);
        }
    }
}