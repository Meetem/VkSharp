using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265ShortTermRefPicSet
    {
        public StdVideoH265ShortTermRefPicSetFlags flags;
        public uint delta_idx_minus1;
        public ushort use_delta_flag;
        public ushort abs_delta_rps_minus1;
        public ushort used_by_curr_pic_flag;
        public ushort used_by_curr_pic_s0_flag;
        public ushort used_by_curr_pic_s1_flag;
        public ushort reserved1;
        public byte reserved2;
        public byte reserved3;
        public byte num_negative_pics;
        public byte num_positive_pics;
        public fixed ushort delta_poc_s0_minus1[16];
        public fixed ushort delta_poc_s1_minus1[16];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265ShortTermRefPicSet Create()
        {
            return default;
        }
        
    }
}
