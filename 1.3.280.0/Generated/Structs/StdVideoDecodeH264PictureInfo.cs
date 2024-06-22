using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH264PictureInfo
    {
        public StdVideoDecodeH264PictureInfoFlags flags;
        public byte seq_parameter_set_id;
        public byte pic_parameter_set_id;
        public byte reserved1;
        public byte reserved2;
        public ushort frame_num;
        public ushort idr_pic_id;
        public fixed int PicOrderCnt[2];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH264PictureInfo Create()
        {
            return default;
        }
        
    }
}
