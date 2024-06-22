using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1LoopFilterFlags
    {
        public uint loop_filter_delta_enabled;
        public uint loop_filter_delta_update;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1LoopFilterFlags Create()
        {
            return default;
        }
        
    }
}
