using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryBarrier2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2KHR srcStageMask;
        public VkAccessFlags2KHR srcAccessMask;
        public VkPipelineStageFlags2KHR dstStageMask;
        public VkAccessFlags2KHR dstAccessMask;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryBarrier2KHR Create()
        {
            return default;
        }
        
    }
}
