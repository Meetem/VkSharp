using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264PictureParameterSet
    {
        public StdVideoH264PpsFlags flags;
        public byte seq_parameter_set_id;
        public byte pic_parameter_set_id;
        public byte num_ref_idx_l0_default_active_minus1;
        public byte num_ref_idx_l1_default_active_minus1;
        public StdVideoH264WeightedBipredIdc weighted_bipred_idc;
        public byte pic_init_qp_minus26;
        public byte pic_init_qs_minus26;
        public byte chroma_qp_index_offset;
        public byte second_chroma_qp_index_offset;
        public StdVideoH264ScalingLists* pScalingLists;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264PictureParameterSet Create()
        {
            return default;
        }
        
    }
}
