using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAttachmentReferenceStencilLayout Create()
        {
            VkAttachmentReferenceStencilLayout ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
