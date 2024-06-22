using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264PictureInfo
    {
        public StdVideoEncodeH264PictureInfoFlags flags;
        public byte seq_parameter_set_id;
        public byte pic_parameter_set_id;
        public ushort idr_pic_id;
        public StdVideoH264PictureType primary_pic_type;
        public uint frame_num;
        public int PicOrderCnt;
        public byte temporal_id;
        public fixed byte reserved1[3];
        public StdVideoEncodeH264ReferenceListsInfo* pRefLists;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264PictureInfo Create()
        {
            return default;
        }
        
    }
}
