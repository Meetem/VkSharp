using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingFragmentDensityMapAttachmentInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingFragmentDensityMapAttachmentInfoEXT Create()
        {
            VkRenderingFragmentDensityMapAttachmentInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
