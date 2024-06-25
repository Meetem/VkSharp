using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetDescriptorBufferOffsets2EXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkSetDescriptorBufferOffsetsInfoEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkSetDescriptorBufferOffsetsInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetDescriptorBufferOffsets2EXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkSetDescriptorBufferOffsetsInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetDescriptorBufferOffsets2EXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkSetDescriptorBufferOffsetsInfoEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetDescriptorBufferOffsets2EXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetDescriptorBufferOffsets2EXT(VkFunctionPointer v) => new PFN_vkCmdSetDescriptorBufferOffsets2EXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetDescriptorBufferOffsets2EXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetDescriptorBufferOffsets2EXT(void* v) => new PFN_vkCmdSetDescriptorBufferOffsets2EXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkSetDescriptorBufferOffsetsInfoEXT pSetDescriptorBufferOffsetsInfo)
        {
            this.ptr(commandBuffer, in pSetDescriptorBufferOffsetsInfo);
        }
    }
}
