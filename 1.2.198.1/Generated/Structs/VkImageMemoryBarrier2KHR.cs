using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageMemoryBarrier2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2KHR srcStageMask;
        public VkAccessFlags2KHR srcAccessMask;
        public VkPipelineStageFlags2KHR dstStageMask;
        public VkAccessFlags2KHR dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageMemoryBarrier2KHR Create()
        {
            return default;
        }
        
    }
}
