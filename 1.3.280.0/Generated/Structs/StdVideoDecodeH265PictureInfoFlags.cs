using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH265PictureInfoFlags
    {
        public uint IrapPicFlag;
        public uint IdrPicFlag;
        public uint IsReference;
        public uint short_term_ref_pic_set_sps_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH265PictureInfoFlags Create()
        {
            return default;
        }
        
    }
}
