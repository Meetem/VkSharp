using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDisplayPlaneProperties2KHR Create()
        {
            return default;
        }
        
    }
}
