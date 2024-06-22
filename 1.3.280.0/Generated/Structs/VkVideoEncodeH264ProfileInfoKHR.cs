using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264ProfileInfoKHR Create()
        {
            VkVideoEncodeH264ProfileInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
