using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance5FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance5;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance5FeaturesKHR Create()
        {
            return default;
        }
        
    }
}
