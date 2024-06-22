using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264QpKHR Create()
        {
            return default;
        }
        
    }
}
