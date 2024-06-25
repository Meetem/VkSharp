using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferImageCopy2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferImageCopy2KHR Create()
        {
            return default;
        }
        
    }
}
