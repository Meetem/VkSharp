using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdWriteTimestamp : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdWriteTimestamp(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdWriteTimestamp(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdWriteTimestamp v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdWriteTimestamp(VkFunctionPointer v) => new PFN_vkCmdWriteTimestamp(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdWriteTimestamp v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdWriteTimestamp(void* v) => new PFN_vkCmdWriteTimestamp(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
        {
            this.ptr(commandBuffer, pipelineStage, queryPool, query);
        }
    }
}
