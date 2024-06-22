using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265PictureParameterSet
    {
        public StdVideoH265PpsFlags flags;
        public byte pps_pic_parameter_set_id;
        public byte pps_seq_parameter_set_id;
        public byte sps_video_parameter_set_id;
        public byte num_extra_slice_header_bits;
        public byte num_ref_idx_l0_default_active_minus1;
        public byte num_ref_idx_l1_default_active_minus1;
        public byte init_qp_minus26;
        public byte diff_cu_qp_delta_depth;
        public byte pps_cb_qp_offset;
        public byte pps_cr_qp_offset;
        public byte pps_beta_offset_div2;
        public byte pps_tc_offset_div2;
        public byte log2_parallel_merge_level_minus2;
        public byte log2_max_transform_skip_block_size_minus2;
        public byte diff_cu_chroma_qp_offset_depth;
        public byte chroma_qp_offset_list_len_minus1;
        public fixed byte cb_qp_offset_list[6];
        public fixed byte cr_qp_offset_list[6];
        public byte log2_sao_offset_scale_luma;
        public byte log2_sao_offset_scale_chroma;
        public byte pps_act_y_qp_offset_plus5;
        public byte pps_act_cb_qp_offset_plus5;
        public byte pps_act_cr_qp_offset_plus3;
        public byte pps_num_palette_predictor_initializers;
        public byte luma_bit_depth_entry_minus8;
        public byte chroma_bit_depth_entry_minus8;
        public byte num_tile_columns_minus1;
        public byte num_tile_rows_minus1;
        public byte reserved1;
        public byte reserved2;
        public fixed ushort column_width_minus1[19];
        public fixed ushort row_height_minus1[21];
        public uint reserved3;
        public StdVideoH265ScalingLists* pScalingLists;
        public StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265PictureParameterSet Create()
        {
            return default;
        }
        
    }
}
