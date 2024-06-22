using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoMaintenance1;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVideoMaintenance1FeaturesKHR Create()
        {
            return default;
        }
        
    }
}
