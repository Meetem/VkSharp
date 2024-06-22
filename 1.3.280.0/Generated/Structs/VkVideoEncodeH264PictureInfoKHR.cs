using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceEntryCount;
        public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;
        public StdVideoEncodeH264PictureInfo* pStdPictureInfo;
        public VkBool32 generatePrefixNalu;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264PictureInfoKHR Create()
        {
            VkVideoEncodeH264PictureInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
