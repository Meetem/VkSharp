using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264SequenceParameterSetVui
    {
        public StdVideoH264SpsVuiFlags flags;
        public StdVideoH264AspectRatioIdc aspect_ratio_idc;
        public ushort sar_width;
        public ushort sar_height;
        public byte video_format;
        public byte colour_primaries;
        public byte transfer_characteristics;
        public byte matrix_coefficients;
        public uint num_units_in_tick;
        public uint time_scale;
        public byte max_num_reorder_frames;
        public byte max_dec_frame_buffering;
        public byte chroma_sample_loc_type_top_field;
        public byte chroma_sample_loc_type_bottom_field;
        public uint reserved1;
        public StdVideoH264HrdParameters* pHrdParameters;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264SequenceParameterSetVui Create()
        {
            return default;
        }
        
    }
}
