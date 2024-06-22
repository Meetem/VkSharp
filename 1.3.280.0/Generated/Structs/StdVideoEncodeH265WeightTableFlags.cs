using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265WeightTableFlags
    {
        public ushort luma_weight_l0_flag;
        public ushort chroma_weight_l0_flag;
        public ushort luma_weight_l1_flag;
        public ushort chroma_weight_l1_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265WeightTableFlags Create()
        {
            return default;
        }
        
    }
}
