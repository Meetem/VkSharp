using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265ReferenceInfo
    {
        public StdVideoEncodeH265ReferenceInfoFlags flags;
        public StdVideoH265PictureType pic_type;
        public int PicOrderCntVal;
        public byte TemporalId;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265ReferenceInfo Create()
        {
            return default;
        }
        
    }
}
