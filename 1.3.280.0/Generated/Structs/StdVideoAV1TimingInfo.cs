using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1TimingInfo
    {
        public StdVideoAV1TimingInfoFlags flags;
        public uint num_units_in_display_tick;
        public uint time_scale;
        public uint num_ticks_per_picture_minus_1;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1TimingInfo Create()
        {
            return default;
        }
        
    }
}
