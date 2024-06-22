using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
    {
        public StdVideoEncodeH265SliceSegmentHeaderFlags flags;
        public StdVideoH265SliceType slice_type;
        public uint slice_segment_address;
        public byte collocated_ref_idx;
        public byte MaxNumMergeCand;
        public byte slice_cb_qp_offset;
        public byte slice_cr_qp_offset;
        public byte slice_beta_offset_div2;
        public byte slice_tc_offset_div2;
        public byte slice_act_y_qp_offset;
        public byte slice_act_cb_qp_offset;
        public byte slice_act_cr_qp_offset;
        public byte slice_qp_delta;
        public ushort reserved1;
        public StdVideoEncodeH265WeightTable* pWeightTable;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265SliceSegmentHeader Create()
        {
            return default;
        }
        
    }
}
