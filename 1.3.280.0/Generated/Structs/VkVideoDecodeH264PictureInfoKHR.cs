using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
        public uint sliceCount;
        public uint* pSliceOffsets;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH264PictureInfoKHR Create()
        {
            VkVideoDecodeH264PictureInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
