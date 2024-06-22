using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageSubresource2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresource imageSubresource;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageSubresource2KHR Create()
        {
            return default;
        }
        
    }
}
