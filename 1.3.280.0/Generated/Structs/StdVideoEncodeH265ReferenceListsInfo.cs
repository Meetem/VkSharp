using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH265ReferenceListsInfo
    {
        public StdVideoEncodeH265ReferenceListsInfoFlags flags;
        public byte num_ref_idx_l0_active_minus1;
        public byte num_ref_idx_l1_active_minus1;
        public fixed byte RefPicList0[15];
        public fixed byte RefPicList1[15];
        public fixed byte list_entry_l0[15];
        public fixed byte list_entry_l1[15];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH265ReferenceListsInfo Create()
        {
            return default;
        }
        
    }
}
