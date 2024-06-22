using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1LoopFilter
    {
        public StdVideoAV1LoopFilterFlags flags;
        public fixed byte loop_filter_level[4];
        public byte loop_filter_sharpness;
        public byte update_ref_delta;
        public fixed byte loop_filter_ref_deltas[8];
        public byte update_mode_delta;
        public fixed byte loop_filter_mode_deltas[2];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1LoopFilter Create()
        {
            return default;
        }
        
    }
}
