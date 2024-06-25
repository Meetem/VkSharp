using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferMemoryBarrier2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2KHR srcStageMask;
        public VkAccessFlags2KHR srcAccessMask;
        public VkPipelineStageFlags2KHR dstStageMask;
        public VkAccessFlags2KHR dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferMemoryBarrier2KHR Create()
        {
            return default;
        }
        
    }
}
