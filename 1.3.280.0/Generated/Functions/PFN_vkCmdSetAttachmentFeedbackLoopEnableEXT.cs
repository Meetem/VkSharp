using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(VkFunctionPointer v) => new PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(void* v) => new PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkImageAspectFlags aspectMask)
        {
            this.ptr(commandBuffer, aspectMask);
        }
    }
}
