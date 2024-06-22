using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeAV1ReferenceInfo
    {
        public StdVideoDecodeAV1ReferenceInfoFlags flags;
        public byte frame_type;
        public byte RefFrameSignBias;
        public byte OrderHint;
        public fixed byte SavedOrderHints[8];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeAV1ReferenceInfo Create()
        {
            return default;
        }
        
    }
}
