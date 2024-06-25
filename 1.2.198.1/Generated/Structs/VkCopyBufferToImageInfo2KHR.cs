using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyBufferToImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkBufferImageCopy2KHR* pRegions;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyBufferToImageInfo2KHR Create()
        {
            return default;
        }
        
    }
}
