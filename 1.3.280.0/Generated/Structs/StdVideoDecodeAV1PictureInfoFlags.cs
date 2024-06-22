using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeAV1PictureInfoFlags
    {
        public uint error_resilient_mode;
        public uint disable_cdf_update;
        public uint use_superres;
        public uint render_and_frame_size_different;
        public uint allow_screen_content_tools;
        public uint is_filter_switchable;
        public uint force_integer_mv;
        public uint frame_size_override_flag;
        public uint buffer_removal_time_present_flag;
        public uint allow_intrabc;
        public uint frame_refs_short_signaling;
        public uint allow_high_precision_mv;
        public uint is_motion_mode_switchable;
        public uint use_ref_frame_mvs;
        public uint disable_frame_end_update_cdf;
        public uint allow_warped_motion;
        public uint reduced_tx_set;
        public uint reference_select;
        public uint skip_mode_present;
        public uint delta_q_present;
        public uint delta_lf_present;
        public uint delta_lf_multi;
        public uint segmentation_enabled;
        public uint segmentation_update_map;
        public uint segmentation_temporal_update;
        public uint segmentation_update_data;
        public uint UsesLr;
        public uint usesChromaLr;
        public uint apply_grain;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeAV1PictureInfoFlags Create()
        {
            return default;
        }
        
    }
}
