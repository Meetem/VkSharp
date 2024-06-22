using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingAttachmentInfo
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
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingAttachmentInfo Create()
        {
            VkRenderingAttachmentInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
