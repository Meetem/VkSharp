using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSynchronization2Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 synchronization2;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSynchronization2Features Create()
        {
            return default;
        }
        
    }
}
