using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkBindDescriptorBufferEmbeddedSamplersInfoEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkBindDescriptorBufferEmbeddedSamplersInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkBindDescriptorBufferEmbeddedSamplersInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkBindDescriptorBufferEmbeddedSamplersInfoEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(VkFunctionPointer v) => new PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(void* v) => new PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkBindDescriptorBufferEmbeddedSamplersInfoEXT pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            this.ptr(commandBuffer, in pBindDescriptorBufferEmbeddedSamplersInfo);
        }
    }
}
