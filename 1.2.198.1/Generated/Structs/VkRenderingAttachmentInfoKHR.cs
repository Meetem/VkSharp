using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkResolveModeFlags resolveMode;
        public VkImageView resolveImageView;
        public VkImageLayout resolveImageLayout;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkClearValue clearValue;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingAttachmentInfoKHR Create()
        {
            VkRenderingAttachmentInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
