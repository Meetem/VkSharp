using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265PictureInfoFlags
    {
        public uint is_reference;
        public uint IrapPicFlag;
        public uint used_for_long_term_reference;
        public uint discardable_flag;
        public uint cross_layer_bla_flag;
        public uint pic_output_flag;
        public uint no_output_of_prior_pics_flag;
        public uint short_term_ref_pic_set_sps_flag;
        public uint slice_temporal_mvp_enabled_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265PictureInfoFlags Create()
        {
            return default;
        }
        
    }
}
