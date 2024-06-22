using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264LevelIdc maxLevelIdc;
        public VkOffset2D fieldOffsetGranularity;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH264CapabilitiesKHR Create()
        {
            VkVideoDecodeH264CapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
