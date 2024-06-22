using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1FilmGrainFlags
    {
        public uint chroma_scaling_from_luma;
        public uint overlap_flag;
        public uint clip_to_restricted_range;
        public uint update_grain;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1FilmGrainFlags Create()
        {
            return default;
        }
        
    }
}
