using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageToMemoryCopyEXT
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
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageToMemoryCopyEXT Create()
        {
            VkImageToMemoryCopyEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
