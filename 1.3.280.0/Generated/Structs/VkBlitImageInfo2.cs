using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBlitImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageBlit2* pRegions;
        public VkFilter filter;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBlitImageInfo2 Create()
        {
            return default;
        }
        
    }
}
