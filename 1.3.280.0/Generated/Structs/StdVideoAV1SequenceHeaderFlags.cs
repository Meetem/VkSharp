using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1SequenceHeaderFlags
    {
        public uint still_picture;
        public uint reduced_still_picture_header;
        public uint use_128x128_superblock;
        public uint enable_filter_intra;
        public uint enable_intra_edge_filter;
        public uint enable_interintra_compound;
        public uint enable_masked_compound;
        public uint enable_warped_motion;
        public uint enable_dual_filter;
        public uint enable_order_hint;
        public uint enable_jnt_comp;
        public uint enable_ref_frame_mvs;
        public uint frame_id_numbers_present_flag;
        public uint enable_superres;
        public uint enable_cdef;
        public uint enable_restoration;
        public uint film_grain_params_present;
        public uint timing_info_present_flag;
        public uint initial_display_delay_present_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1SequenceHeaderFlags Create()
        {
            return default;
        }
        
    }
}
