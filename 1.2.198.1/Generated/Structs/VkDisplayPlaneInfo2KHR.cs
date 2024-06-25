using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModeKHR mode;
        public uint planeIndex;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDisplayPlaneInfo2KHR Create()
        {
            return default;
        }
        
    }
}
