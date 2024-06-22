using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint temporalLayerCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264RateControlInfoKHR Create()
        {
            VkVideoEncodeH264RateControlInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
