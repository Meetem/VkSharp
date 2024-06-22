using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH264ScalingLists
    {
        public ushort scaling_list_present_mask;
        public ushort use_default_scaling_matrix_mask;
        public fixed byte ScalingList4x4[96];
        public fixed byte ScalingList8x8[384];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH264ScalingLists Create()
        {
            return default;
        }
        
    }
}
