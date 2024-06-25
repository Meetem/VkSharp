using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance3Properties Create()
        {
            return default;
        }
        
    }
}
