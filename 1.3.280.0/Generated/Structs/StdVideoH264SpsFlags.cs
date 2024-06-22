using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264SpsFlags
    {
        public uint constraint_set0_flag;
        public uint constraint_set1_flag;
        public uint constraint_set2_flag;
        public uint constraint_set3_flag;
        public uint constraint_set4_flag;
        public uint constraint_set5_flag;
        public uint direct_8x8_inference_flag;
        public uint mb_adaptive_frame_field_flag;
        public uint frame_mbs_only_flag;
        public uint delta_pic_order_always_zero_flag;
        public uint separate_colour_plane_flag;
        public uint gaps_in_frame_num_value_allowed_flag;
        public uint qpprime_y_zero_transform_bypass_flag;
        public uint frame_cropping_flag;
        public uint seq_scaling_matrix_present_flag;
        public uint vui_parameters_present_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264SpsFlags Create()
        {
            return default;
        }
        
    }
}
