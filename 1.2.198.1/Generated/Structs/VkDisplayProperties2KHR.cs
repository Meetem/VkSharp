using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDisplayProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPropertiesKHR displayProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDisplayProperties2KHR Create()
        {
            return default;
        }
        
    }
}
