using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264SequenceParameterSet
    {
        public StdVideoH264SpsFlags flags;
        public StdVideoH264ProfileIdc profile_idc;
        public StdVideoH264LevelIdc level_idc;
        public StdVideoH264ChromaFormatIdc chroma_format_idc;
        public byte seq_parameter_set_id;
        public byte bit_depth_luma_minus8;
        public byte bit_depth_chroma_minus8;
        public byte log2_max_frame_num_minus4;
        public StdVideoH264PocType pic_order_cnt_type;
        public int offset_for_non_ref_pic;
        public int offset_for_top_to_bottom_field;
        public byte log2_max_pic_order_cnt_lsb_minus4;
        public byte num_ref_frames_in_pic_order_cnt_cycle;
        public byte max_num_ref_frames;
        public byte reserved1;
        public uint pic_width_in_mbs_minus1;
        public uint pic_height_in_map_units_minus1;
        public uint frame_crop_left_offset;
        public uint frame_crop_right_offset;
        public uint frame_crop_top_offset;
        public uint frame_crop_bottom_offset;
        public uint reserved2;
        public int* pOffsetForRefFrame;
        public StdVideoH264ScalingLists* pScalingLists;
        public StdVideoH264SequenceParameterSetVui* pSequenceParameterSetVui;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264SequenceParameterSet Create()
        {
            return default;
        }
        
    }
}
