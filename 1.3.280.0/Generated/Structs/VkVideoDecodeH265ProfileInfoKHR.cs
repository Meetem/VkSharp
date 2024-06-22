using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH265ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH265ProfileIdc stdProfileIdc;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH265ProfileInfoKHR Create()
        {
            VkVideoDecodeH265ProfileInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
