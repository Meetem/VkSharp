using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 srcStageMask;
        public VkAccessFlags2 srcAccessMask;
        public VkPipelineStageFlags2 dstStageMask;
        public VkAccessFlags2 dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferMemoryBarrier2 Create()
        {
            return default;
        }
        
    }
}
