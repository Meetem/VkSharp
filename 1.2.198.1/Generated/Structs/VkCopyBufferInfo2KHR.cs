using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyBufferInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferCopy2KHR* pRegions;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyBufferInfo2KHR Create()
        {
            return default;
        }
        
    }
}
