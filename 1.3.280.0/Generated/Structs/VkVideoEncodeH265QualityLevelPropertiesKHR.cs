using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredSubLayerCount;
        public VkVideoEncodeH265QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265QualityLevelPropertiesKHR Create()
        {
            VkVideoEncodeH265QualityLevelPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
