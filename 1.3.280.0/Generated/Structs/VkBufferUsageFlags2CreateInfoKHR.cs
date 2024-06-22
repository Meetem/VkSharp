using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferUsageFlags2CreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferUsageFlags2KHR usage;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferUsageFlags2CreateInfoKHR Create()
        {
            return default;
        }
        
    }
}
