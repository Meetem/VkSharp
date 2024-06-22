using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyImageToMemoryInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public uint regionCount;
        public VkImageToMemoryCopyEXT* pRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyImageToMemoryInfoEXT Create()
        {
            VkCopyImageToMemoryInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
