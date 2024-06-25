using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageUsageFlags usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFramebufferAttachmentImageInfo Create()
        {
            VkFramebufferAttachmentImageInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
