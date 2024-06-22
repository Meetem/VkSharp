using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceIDProperties Create()
        {
            return default;
        }
        
    }
}
