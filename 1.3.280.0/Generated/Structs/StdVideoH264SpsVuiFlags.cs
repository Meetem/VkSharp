using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264SpsVuiFlags
    {
        public uint aspect_ratio_info_present_flag;
        public uint overscan_info_present_flag;
        public uint overscan_appropriate_flag;
        public uint video_signal_type_present_flag;
        public uint video_full_range_flag;
        public uint color_description_present_flag;
        public uint chroma_loc_info_present_flag;
        public uint timing_info_present_flag;
        public uint fixed_frame_rate_flag;
        public uint bitstream_restriction_flag;
        public uint nal_hrd_parameters_present_flag;
        public uint vcl_hrd_parameters_present_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264SpsVuiFlags Create()
        {
            return default;
        }
        
    }
}
