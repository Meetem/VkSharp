using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264RefPicMarkingEntry
    {
        public StdVideoH264MemMgmtControlOp memory_management_control_operation;
        public ushort difference_of_pic_nums_minus1;
        public ushort long_term_pic_num;
        public ushort long_term_frame_idx;
        public ushort max_long_term_frame_idx_plus1;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264RefPicMarkingEntry Create()
        {
            return default;
        }
        
    }
}
