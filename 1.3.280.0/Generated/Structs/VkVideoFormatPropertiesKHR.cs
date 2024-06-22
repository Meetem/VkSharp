using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoFormatPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkComponentMapping componentMapping;
        public VkImageCreateFlags imageCreateFlags;
        public VkImageType imageType;
        public VkImageTiling imageTiling;
        public VkImageUsageFlags imageUsageFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoFormatPropertiesKHR Create()
        {
            VkVideoFormatPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
