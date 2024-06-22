using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265HrdParameters
    {
        public StdVideoH265HrdFlags flags;
        public byte tick_divisor_minus2;
        public byte du_cpb_removal_delay_increment_length_minus1;
        public byte dpb_output_delay_du_length_minus1;
        public byte bit_rate_scale;
        public byte cpb_size_scale;
        public byte cpb_size_du_scale;
        public byte initial_cpb_removal_delay_length_minus1;
        public byte au_cpb_removal_delay_length_minus1;
        public byte dpb_output_delay_length_minus1;
        public fixed byte cpb_cnt_minus1[7];
        public fixed ushort elemental_duration_in_tc_minus1[7];
        public fixed ushort reserved[3];
        public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersNal;
        public StdVideoH265SubLayerHrdParameters* pSubLayerHrdParametersVcl;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265HrdParameters Create()
        {
            return default;
        }
        
    }
}
