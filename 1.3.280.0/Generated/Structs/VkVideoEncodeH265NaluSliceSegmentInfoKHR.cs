using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH265SliceSegmentHeader* pStdSliceSegmentHeader;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265NaluSliceSegmentInfoKHR Create()
        {
            VkVideoEncodeH265NaluSliceSegmentInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
