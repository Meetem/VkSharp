using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265DecPicBufMgr
    {
        public fixed uint max_latency_increase_plus1[7];
        public fixed byte max_dec_pic_buffering_minus1[7];
        public fixed byte max_num_reorder_pics[7];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265DecPicBufMgr Create()
        {
            return default;
        }
        
    }
}
