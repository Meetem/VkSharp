using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265ProfileTierLevelFlags
    {
        public uint general_tier_flag;
        public uint general_progressive_source_flag;
        public uint general_interlaced_source_flag;
        public uint general_non_packed_constraint_flag;
        public uint general_frame_only_constraint_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265ProfileTierLevelFlags Create()
        {
            return default;
        }
        
    }
}
