using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264SliceHeader
    {
        public StdVideoEncodeH264SliceHeaderFlags flags;
        public uint first_mb_in_slice;
        public StdVideoH264SliceType slice_type;
        public byte slice_alpha_c0_offset_div2;
        public byte slice_beta_offset_div2;
        public byte slice_qp_delta;
        public byte reserved1;
        public StdVideoH264CabacInitIdc cabac_init_idc;
        public StdVideoH264DisableDeblockingFilterIdc disable_deblocking_filter_idc;
        public StdVideoEncodeH264WeightTable* pWeightTable;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264SliceHeader Create()
        {
            return default;
        }
        
    }
}
