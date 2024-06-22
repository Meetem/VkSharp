using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeAV1ReferenceInfoFlags
    {
        public uint disable_frame_end_update_cdf;
        public uint segmentation_enabled;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeAV1ReferenceInfoFlags Create()
        {
            return default;
        }
        
    }
}
