using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265HrdFlags
    {
        public uint nal_hrd_parameters_present_flag;
        public uint vcl_hrd_parameters_present_flag;
        public uint sub_pic_hrd_params_present_flag;
        public uint sub_pic_cpb_params_in_pic_timing_sei_flag;
        public uint fixed_pic_rate_general_flag;
        public uint fixed_pic_rate_within_cvs_flag;
        public uint low_delay_hrd_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265HrdFlags Create()
        {
            return default;
        }
        
    }
}
