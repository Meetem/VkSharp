using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMaxLevelIdc;
        public StdVideoH265LevelIdc maxLevelIdc;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265SessionCreateInfoKHR Create()
        {
            VkVideoEncodeH265SessionCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
