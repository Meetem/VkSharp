using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetQueueCheckpointData2NV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointData2NV*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointData2NV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueueCheckpointData2NV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointData2NV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueueCheckpointData2NV(delegate *unmanaged[Cdecl]<VkQueue, ref uint, VkCheckpointData2NV*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetQueueCheckpointData2NV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueueCheckpointData2NV(VkFunctionPointer v) => new PFN_vkGetQueueCheckpointData2NV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetQueueCheckpointData2NV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueueCheckpointData2NV(void* v) => new PFN_vkGetQueueCheckpointData2NV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            this.ptr(queue, ref pCheckpointDataCount, pCheckpointData);
        }
    }
}
