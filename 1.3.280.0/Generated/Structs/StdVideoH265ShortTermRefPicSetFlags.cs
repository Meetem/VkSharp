using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265ShortTermRefPicSetFlags
    {
        public uint inter_ref_pic_set_prediction_flag;
        public uint delta_rps_sign;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265ShortTermRefPicSetFlags Create()
        {
            return default;
        }
        
    }
}
