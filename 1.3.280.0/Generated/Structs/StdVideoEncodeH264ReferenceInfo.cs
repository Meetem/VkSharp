using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264ReferenceInfo
    {
        public StdVideoEncodeH264ReferenceInfoFlags flags;
        public StdVideoH264PictureType primary_pic_type;
        public uint FrameNum;
        public int PicOrderCnt;
        public ushort long_term_pic_num;
        public ushort long_term_frame_idx;
        public byte temporal_id;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264ReferenceInfo Create()
        {
            return default;
        }
        
    }
}
