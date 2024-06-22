using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceSegmentEntryCount;
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;
        public StdVideoEncodeH265PictureInfo* pStdPictureInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265PictureInfoKHR Create()
        {
            VkVideoEncodeH265PictureInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
