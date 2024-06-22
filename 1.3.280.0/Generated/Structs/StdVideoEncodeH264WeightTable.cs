using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264WeightTable
    {
        public StdVideoEncodeH264WeightTableFlags flags;
        public byte luma_log2_weight_denom;
        public byte chroma_log2_weight_denom;
        public fixed byte luma_weight_l0[32];
        public fixed byte luma_offset_l0[32];
        public fixed byte chroma_weight_l0[64];
        public fixed byte chroma_offset_l0[64];
        public fixed byte luma_weight_l1[32];
        public fixed byte luma_offset_l1[32];
        public fixed byte chroma_weight_l1[64];
        public fixed byte chroma_offset_l1[64];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264WeightTable Create()
        {
            return default;
        }
        
    }
}
