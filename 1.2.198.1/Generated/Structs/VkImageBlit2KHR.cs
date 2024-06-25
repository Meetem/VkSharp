using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageBlit2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public FixedArrayVkOffset3DSize2 srcOffsets;
        public VkImageSubresourceLayers dstSubresource;
        public FixedArrayVkOffset3DSize2 dstOffsets;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageBlit2KHR Create()
        {
            return default;
        }
        
    }
}
