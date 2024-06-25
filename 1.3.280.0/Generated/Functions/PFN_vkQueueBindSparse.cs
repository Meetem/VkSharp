using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueBindSparse : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueBindSparse(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueBindSparse(delegate *unmanaged[Cdecl]<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueBindSparse v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueBindSparse(VkFunctionPointer v) => new PFN_vkQueueBindSparse(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueBindSparse v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueBindSparse(void* v) => new PFN_vkQueueBindSparse(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            return this.ptr(queue, bindInfoCount, pBindInfo, fence);
        }
    }
}
