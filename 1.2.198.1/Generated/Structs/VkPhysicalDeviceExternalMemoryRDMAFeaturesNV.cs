using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 externalMemoryRDMA;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExternalMemoryRDMAFeaturesNV Create()
        {
            return default;
        }
        
    }
}
