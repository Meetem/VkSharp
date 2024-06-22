using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265VideoParameterSet
    {
        public StdVideoH265VpsFlags flags;
        public byte vps_video_parameter_set_id;
        public byte vps_max_sub_layers_minus1;
        public byte reserved1;
        public byte reserved2;
        public uint vps_num_units_in_tick;
        public uint vps_time_scale;
        public uint vps_num_ticks_poc_diff_one_minus1;
        public uint reserved3;
        public StdVideoH265DecPicBufMgr* pDecPicBufMgr;
        public StdVideoH265HrdParameters* pHrdParameters;
        public StdVideoH265ProfileTierLevel* pProfileTierLevel;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265VideoParameterSet Create()
        {
            return default;
        }
        
    }
}
