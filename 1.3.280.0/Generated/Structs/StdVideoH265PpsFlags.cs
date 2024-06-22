using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265PpsFlags
    {
        public uint dependent_slice_segments_enabled_flag;
        public uint output_flag_present_flag;
        public uint sign_data_hiding_enabled_flag;
        public uint cabac_init_present_flag;
        public uint constrained_intra_pred_flag;
        public uint transform_skip_enabled_flag;
        public uint cu_qp_delta_enabled_flag;
        public uint pps_slice_chroma_qp_offsets_present_flag;
        public uint weighted_pred_flag;
        public uint weighted_bipred_flag;
        public uint transquant_bypass_enabled_flag;
        public uint tiles_enabled_flag;
        public uint entropy_coding_sync_enabled_flag;
        public uint uniform_spacing_flag;
        public uint loop_filter_across_tiles_enabled_flag;
        public uint pps_loop_filter_across_slices_enabled_flag;
        public uint deblocking_filter_control_present_flag;
        public uint deblocking_filter_override_enabled_flag;
        public uint pps_deblocking_filter_disabled_flag;
        public uint pps_scaling_list_data_present_flag;
        public uint lists_modification_present_flag;
        public uint slice_segment_header_extension_present_flag;
        public uint pps_extension_present_flag;
        public uint cross_component_prediction_enabled_flag;
        public uint chroma_qp_offset_list_enabled_flag;
        public uint pps_curr_pic_ref_enabled_flag;
        public uint residual_adaptive_colour_transform_enabled_flag;
        public uint pps_slice_act_qp_offsets_present_flag;
        public uint pps_palette_predictor_initializers_present_flag;
        public uint monochrome_palette_flag;
        public uint pps_range_extension_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265PpsFlags Create()
        {
            return default;
        }
        
    }
}
