using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1SequenceHeader
    {
        public StdVideoAV1SequenceHeaderFlags flags;
        public StdVideoAV1Profile seq_profile;
        public byte frame_width_bits_minus_1;
        public byte frame_height_bits_minus_1;
        public ushort max_frame_width_minus_1;
        public ushort max_frame_height_minus_1;
        public byte delta_frame_id_length_minus_2;
        public byte additional_frame_id_length_minus_1;
        public byte order_hint_bits_minus_1;
        public byte seq_force_integer_mv;
        public byte seq_force_screen_content_tools;
        public fixed byte reserved1[5];
        public StdVideoAV1ColorConfig* pColorConfig;
        public StdVideoAV1TimingInfo* pTimingInfo;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1SequenceHeader Create()
        {
            return default;
        }
        
    }
}
