using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetQueueCheckpointDataNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointDataNV*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointDataNV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueueCheckpointDataNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointDataNV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueueCheckpointDataNV(delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointDataNV*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetQueueCheckpointDataNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueueCheckpointDataNV(VkFunctionPointer v) => new PFN_vkGetQueueCheckpointDataNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetQueueCheckpointDataNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueueCheckpointDataNV(void* v) => new PFN_vkGetQueueCheckpointDataNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            this.ptr(queue, ref pCheckpointDataCount, pCheckpointData);
        }
    }
}
