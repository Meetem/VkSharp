using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint subLayerCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265RateControlInfoKHR Create()
        {
            VkVideoEncodeH265RateControlInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
