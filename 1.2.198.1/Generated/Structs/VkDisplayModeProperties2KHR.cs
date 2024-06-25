using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDisplayModeProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDisplayModeProperties2KHR Create()
        {
            return default;
        }
        
    }
}
