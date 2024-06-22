using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFramebufferAttachmentsCreateInfo Create()
        {
            VkFramebufferAttachmentsCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
