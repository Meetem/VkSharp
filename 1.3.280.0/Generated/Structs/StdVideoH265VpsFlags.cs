using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265VpsFlags
    {
        public uint vps_temporal_id_nesting_flag;
        public uint vps_sub_layer_ordering_info_present_flag;
        public uint vps_timing_info_present_flag;
        public uint vps_poc_proportional_to_timing_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265VpsFlags Create()
        {
            return default;
        }
        
    }
}
