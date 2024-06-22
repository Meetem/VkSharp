using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1QuantizationFlags
    {
        public uint using_qmatrix;
        public uint diff_uv_delta;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1QuantizationFlags Create()
        {
            return default;
        }
        
    }
}
