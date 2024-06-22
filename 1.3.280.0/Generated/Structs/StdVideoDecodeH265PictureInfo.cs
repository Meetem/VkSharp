using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH265PictureInfo
    {
        public StdVideoDecodeH265PictureInfoFlags flags;
        public byte sps_video_parameter_set_id;
        public byte pps_seq_parameter_set_id;
        public byte pps_pic_parameter_set_id;
        public byte NumDeltaPocsOfRefRpsIdx;
        public int PicOrderCntVal;
        public ushort NumBitsForSTRefPicSetInSlice;
        public ushort reserved;
        public fixed byte RefPicSetStCurrBefore[8];
        public fixed byte RefPicSetStCurrAfter[8];
        public fixed byte RefPicSetLtCurr[8];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH265PictureInfo Create()
        {
            return default;
        }
        
    }
}
