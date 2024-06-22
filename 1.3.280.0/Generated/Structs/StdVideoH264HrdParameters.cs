using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264HrdParameters
    {
        public byte cpb_cnt_minus1;
        public byte bit_rate_scale;
        public byte cpb_size_scale;
        public byte reserved1;
        public fixed uint bit_rate_value_minus1[32];
        public fixed uint cpb_size_value_minus1[32];
        public fixed byte cbr_flag[32];
        public uint initial_cpb_removal_delay_length_minus1;
        public uint cpb_removal_delay_length_minus1;
        public uint dpb_output_delay_length_minus1;
        public uint time_offset_length;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264HrdParameters Create()
        {
            return default;
        }
        
    }
}
