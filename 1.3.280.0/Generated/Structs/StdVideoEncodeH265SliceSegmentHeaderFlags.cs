using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265SliceSegmentHeaderFlags
    {
        public uint first_slice_segment_in_pic_flag;
        public uint dependent_slice_segment_flag;
        public uint slice_sao_luma_flag;
        public uint slice_sao_chroma_flag;
        public uint num_ref_idx_active_override_flag;
        public uint mvd_l1_zero_flag;
        public uint cabac_init_flag;
        public uint cu_chroma_qp_offset_enabled_flag;
        public uint deblocking_filter_override_flag;
        public uint slice_deblocking_filter_disabled_flag;
        public uint collocated_from_l0_flag;
        public uint slice_loop_filter_across_slices_enabled_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265SliceSegmentHeaderFlags Create()
        {
            return default;
        }
        
    }
}
