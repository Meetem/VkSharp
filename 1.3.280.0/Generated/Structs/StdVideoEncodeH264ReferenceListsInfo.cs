using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
    {
        public StdVideoEncodeH264ReferenceListsInfoFlags flags;
        public byte num_ref_idx_l0_active_minus1;
        public byte num_ref_idx_l1_active_minus1;
        public fixed byte RefPicList0[32];
        public fixed byte RefPicList1[32];
        public byte refList0ModOpCount;
        public byte refList1ModOpCount;
        public byte refPicMarkingOpCount;
        public fixed byte reserved1[7];
        public StdVideoEncodeH264RefListModEntry* pRefList0ModOperations;
        public StdVideoEncodeH264RefListModEntry* pRefList1ModOperations;
        public StdVideoEncodeH264RefPicMarkingEntry* pRefPicMarkingOperations;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264ReferenceListsInfo Create()
        {
            return default;
        }
        
    }
}
