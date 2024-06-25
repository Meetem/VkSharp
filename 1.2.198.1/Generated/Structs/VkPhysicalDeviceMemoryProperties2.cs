using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMemoryProperties2 Create()
        {
            return default;
        }
        
    }
}
