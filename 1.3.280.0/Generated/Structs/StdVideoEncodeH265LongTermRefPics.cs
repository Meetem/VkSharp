using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265LongTermRefPics
    {
        public byte num_long_term_sps;
        public byte num_long_term_pics;
        public fixed byte lt_idx_sps[32];
        public fixed byte poc_lsb_lt[16];
        public ushort used_by_curr_pic_lt_flag;
        public fixed byte delta_poc_msb_present_flag[48];
        public fixed byte delta_poc_msb_cycle_lt[48];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265LongTermRefPics Create()
        {
            return default;
        }
        
    }
}
