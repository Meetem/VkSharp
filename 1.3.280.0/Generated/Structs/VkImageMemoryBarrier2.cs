using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 srcStageMask;
        public VkAccessFlags2 srcAccessMask;
        public VkPipelineStageFlags2 dstStageMask;
        public VkAccessFlags2 dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageMemoryBarrier2 Create()
        {
            return default;
        }
        
    }
}
