using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
        public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH264ProfileInfoKHR Create()
        {
            VkVideoDecodeH264ProfileInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
