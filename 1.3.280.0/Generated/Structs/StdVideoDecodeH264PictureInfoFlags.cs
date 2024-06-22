using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH264PictureInfoFlags
    {
        public uint field_pic_flag;
        public uint is_intra;
        public uint IdrPicFlag;
        public uint bottom_field_flag;
        public uint is_reference;
        public uint complementary_field_pair;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH264PictureInfoFlags Create()
        {
            return default;
        }
        
    }
}
