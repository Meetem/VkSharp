using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265FrameSizeKHR Create()
        {
            return default;
        }
        
    }
}
