using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264NaluSliceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH264SliceHeader* pStdSliceHeader;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264NaluSliceInfoKHR Create()
        {
            VkVideoEncodeH264NaluSliceInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
