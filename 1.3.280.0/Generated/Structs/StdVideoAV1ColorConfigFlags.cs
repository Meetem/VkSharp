using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1ColorConfigFlags
    {
        public uint mono_chrome;
        public uint color_range;
        public uint separate_uv_delta_q;
        public uint color_description_present_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1ColorConfigFlags Create()
        {
            return default;
        }
        
    }
}
