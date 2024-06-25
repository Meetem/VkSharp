using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfaceFormat2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceFormatKHR surfaceFormat;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfaceFormat2KHR Create()
        {
            return default;
        }
        
    }
}
