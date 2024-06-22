using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilInitialLayout;
        public VkImageLayout stencilFinalLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAttachmentDescriptionStencilLayout Create()
        {
            VkAttachmentDescriptionStencilLayout ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
