using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264WeightTableFlags
    {
        public uint luma_weight_l0_flag;
        public uint chroma_weight_l0_flag;
        public uint luma_weight_l1_flag;
        public uint chroma_weight_l1_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264WeightTableFlags Create()
        {
            return default;
        }
        
    }
}
