using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265LongTermRefPicsSps
    {
        public uint used_by_curr_pic_lt_sps_flag;
        public fixed uint lt_ref_pic_poc_lsb_sps[32];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265LongTermRefPicsSps Create()
        {
            return default;
        }
        
    }
}
