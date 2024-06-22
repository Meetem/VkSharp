using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryToImageCopyEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryToImageCopyEXT Create()
        {
            VkMemoryToImageCopyEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
