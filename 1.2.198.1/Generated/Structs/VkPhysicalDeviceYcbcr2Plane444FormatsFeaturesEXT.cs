using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcr2plane444Formats;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
