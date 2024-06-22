using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264PpsFlags
    {
        public uint transform_8x8_mode_flag;
        public uint redundant_pic_cnt_present_flag;
        public uint constrained_intra_pred_flag;
        public uint deblocking_filter_control_present_flag;
        public uint weighted_pred_flag;
        public uint bottom_field_pic_order_in_frame_present_flag;
        public uint entropy_coding_mode_flag;
        public uint pic_scaling_matrix_present_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264PpsFlags Create()
        {
            return default;
        }
        
    }
}
