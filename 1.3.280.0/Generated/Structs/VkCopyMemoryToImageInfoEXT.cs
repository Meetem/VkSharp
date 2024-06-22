using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyMemoryToImageInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagsEXT flags;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkMemoryToImageCopyEXT* pRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyMemoryToImageInfoEXT Create()
        {
            VkCopyMemoryToImageInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
