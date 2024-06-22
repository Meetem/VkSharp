using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoPictureResourceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOffset2D codedOffset;
        public VkExtent2D codedExtent;
        public uint baseArrayLayer;
        public VkImageView imageViewBinding;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoPictureResourceInfoKHR Create()
        {
            VkVideoPictureResourceInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
