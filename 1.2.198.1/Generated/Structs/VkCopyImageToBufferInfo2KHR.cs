using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyImageToBufferInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferImageCopy2KHR* pRegions;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyImageToBufferInfo2KHR Create()
        {
            return default;
        }
        
    }
}
