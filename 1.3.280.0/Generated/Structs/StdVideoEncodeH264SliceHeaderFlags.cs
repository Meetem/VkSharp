using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264SliceHeaderFlags
    {
        public uint direct_spatial_mv_pred_flag;
        public uint num_ref_idx_active_override_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264SliceHeaderFlags Create()
        {
            return default;
        }
        
    }
}
