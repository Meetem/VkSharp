using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264RefListModEntry
    {
        public StdVideoH264ModificationOfPicNumsIdc modification_of_pic_nums_idc;
        public ushort abs_diff_pic_num_minus1;
        public ushort long_term_pic_num;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264RefListModEntry Create()
        {
            return default;
        }
        
    }
}
