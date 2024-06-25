using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(VkFunctionPointer v) => new PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(void* v) => new PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            this.ptr(commandBuffer, pipelineBindPoint, layout, set);
        }
    }
}
