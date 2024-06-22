using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyImageToImageInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyImageToImageInfoEXT Create()
        {
            VkCopyImageToImageInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
