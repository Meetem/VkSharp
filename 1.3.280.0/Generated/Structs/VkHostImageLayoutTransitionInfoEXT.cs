using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkHostImageLayoutTransitionInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public VkImageSubresourceRange subresourceRange;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkHostImageLayoutTransitionInfoEXT Create()
        {
            VkHostImageLayoutTransitionInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
