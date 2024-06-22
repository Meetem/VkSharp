using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH264ReferenceInfo
    {
        public StdVideoDecodeH264ReferenceInfoFlags flags;
        public ushort FrameNum;
        public ushort reserved;
        public fixed int PicOrderCnt[2];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH264ReferenceInfo Create()
        {
            return default;
        }
        
    }
}
