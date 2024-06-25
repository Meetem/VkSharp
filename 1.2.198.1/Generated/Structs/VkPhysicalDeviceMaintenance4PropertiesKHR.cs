using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance4PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxBufferSize;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance4PropertiesKHR Create()
        {
            return default;
        }
        
    }
}
