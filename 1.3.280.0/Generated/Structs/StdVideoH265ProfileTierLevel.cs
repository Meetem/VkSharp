using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265ProfileTierLevel
    {
        public StdVideoH265ProfileTierLevelFlags flags;
        public StdVideoH265ProfileIdc general_profile_idc;
        public StdVideoH265LevelIdc general_level_idc;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265ProfileTierLevel Create()
        {
            return default;
        }
        
    }
}
