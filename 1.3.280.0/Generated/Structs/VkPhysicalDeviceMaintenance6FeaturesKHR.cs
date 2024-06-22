using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance6FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance6;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance6FeaturesKHR Create()
        {
            return default;
        }
        
    }
}
