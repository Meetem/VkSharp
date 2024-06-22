using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265WeightTable
    {
        public StdVideoEncodeH265WeightTableFlags flags;
        public byte luma_log2_weight_denom;
        public byte delta_chroma_log2_weight_denom;
        public fixed byte delta_luma_weight_l0[15];
        public fixed byte luma_offset_l0[15];
        public fixed byte delta_chroma_weight_l0[30];
        public fixed byte delta_chroma_offset_l0[30];
        public fixed byte delta_luma_weight_l1[15];
        public fixed byte luma_offset_l1[15];
        public fixed byte delta_chroma_weight_l1[30];
        public fixed byte delta_chroma_offset_l1[30];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265WeightTable Create()
        {
            return default;
        }
        
    }
}
