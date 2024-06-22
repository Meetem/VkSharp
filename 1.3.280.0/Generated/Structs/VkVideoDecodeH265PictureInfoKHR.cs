using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH265PictureInfo* pStdPictureInfo;
        public uint sliceSegmentCount;
        public uint* pSliceSegmentOffsets;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH265PictureInfoKHR Create()
        {
            VkVideoDecodeH265PictureInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
