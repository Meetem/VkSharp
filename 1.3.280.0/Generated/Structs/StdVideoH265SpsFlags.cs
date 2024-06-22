using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265SpsFlags
    {
        public uint sps_temporal_id_nesting_flag;
        public uint separate_colour_plane_flag;
        public uint conformance_window_flag;
        public uint sps_sub_layer_ordering_info_present_flag;
        public uint scaling_list_enabled_flag;
        public uint sps_scaling_list_data_present_flag;
        public uint amp_enabled_flag;
        public uint sample_adaptive_offset_enabled_flag;
        public uint pcm_enabled_flag;
        public uint pcm_loop_filter_disabled_flag;
        public uint long_term_ref_pics_present_flag;
        public uint sps_temporal_mvp_enabled_flag;
        public uint strong_intra_smoothing_enabled_flag;
        public uint vui_parameters_present_flag;
        public uint sps_extension_present_flag;
        public uint sps_range_extension_flag;
        public uint transform_skip_rotation_enabled_flag;
        public uint transform_skip_context_enabled_flag;
        public uint implicit_rdpcm_enabled_flag;
        public uint explicit_rdpcm_enabled_flag;
        public uint extended_precision_processing_flag;
        public uint intra_smoothing_disabled_flag;
        public uint high_precision_offsets_enabled_flag;
        public uint persistent_rice_adaptation_enabled_flag;
        public uint cabac_bypass_alignment_enabled_flag;
        public uint sps_scc_extension_flag;
        public uint sps_curr_pic_ref_enabled_flag;
        public uint palette_mode_enabled_flag;
        public uint sps_palette_predictor_initializers_present_flag;
        public uint intra_boundary_filtering_disabled_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265SpsFlags Create()
        {
            return default;
        }
        
    }
}
