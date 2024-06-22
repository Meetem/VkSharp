using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265PictureInfo
    {
        public StdVideoEncodeH265PictureInfoFlags flags;
        public StdVideoH265PictureType pic_type;
        public byte sps_video_parameter_set_id;
        public byte pps_seq_parameter_set_id;
        public byte pps_pic_parameter_set_id;
        public byte short_term_ref_pic_set_idx;
        public int PicOrderCntVal;
        public byte TemporalId;
        public fixed byte reserved1[7];
        public StdVideoEncodeH265ReferenceListsInfo* pRefLists;
        public StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet;
        public StdVideoEncodeH265LongTermRefPics* pLongTermRefPics;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265PictureInfo Create()
        {
            return default;
        }
        
    }
}
