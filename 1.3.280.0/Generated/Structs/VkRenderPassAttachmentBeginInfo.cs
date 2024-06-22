using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassAttachmentBeginInfo Create()
        {
            VkRenderPassAttachmentBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
