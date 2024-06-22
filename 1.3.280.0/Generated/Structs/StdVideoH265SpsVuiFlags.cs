using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265SpsVuiFlags
    {
        public uint aspect_ratio_info_present_flag;
        public uint overscan_info_present_flag;
        public uint overscan_appropriate_flag;
        public uint video_signal_type_present_flag;
        public uint video_full_range_flag;
        public uint colour_description_present_flag;
        public uint chroma_loc_info_present_flag;
        public uint neutral_chroma_indication_flag;
        public uint field_seq_flag;
        public uint frame_field_info_present_flag;
        public uint default_display_window_flag;
        public uint vui_timing_info_present_flag;
        public uint vui_poc_proportional_to_timing_flag;
        public uint vui_hrd_parameters_present_flag;
        public uint bitstream_restriction_flag;
        public uint tiles_fixed_structure_flag;
        public uint motion_vectors_over_pic_boundaries_flag;
        public uint restricted_ref_pic_lists_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265SpsVuiFlags Create()
        {
            return default;
        }
        
    }
}
