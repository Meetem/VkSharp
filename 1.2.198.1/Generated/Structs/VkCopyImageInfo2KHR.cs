using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyImageInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2KHR* pRegions;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyImageInfo2KHR Create()
        {
            return default;
        }
        
    }
}
