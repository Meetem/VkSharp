using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265ScalingLists
    {
        public fixed byte ScalingList4x4[96];
        public fixed byte ScalingList8x8[384];
        public fixed byte ScalingList16x16[384];
        public fixed byte ScalingList32x32[128];
        public fixed byte ScalingListDCCoef16x16[6];
        public fixed byte ScalingListDCCoef32x32[2];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265ScalingLists Create()
        {
            return default;
        }
        
    }
}
