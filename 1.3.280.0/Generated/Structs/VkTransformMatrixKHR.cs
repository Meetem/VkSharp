using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkTransformMatrixKHR
    {
        public fixed float matrix[12];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkTransformMatrixKHR Create()
        {
            return default;
        }
        
    }
}
