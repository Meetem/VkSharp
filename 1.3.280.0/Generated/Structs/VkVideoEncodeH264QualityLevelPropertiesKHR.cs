using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredTemporalLayerCount;
        public VkVideoEncodeH264QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public VkBool32 preferredStdEntropyCodingModeFlag;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264QualityLevelPropertiesKHR Create()
        {
            VkVideoEncodeH264QualityLevelPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
