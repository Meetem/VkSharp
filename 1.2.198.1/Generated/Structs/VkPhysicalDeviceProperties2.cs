using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties properties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceProperties2 Create()
        {
            return default;
        }
        
    }
}
