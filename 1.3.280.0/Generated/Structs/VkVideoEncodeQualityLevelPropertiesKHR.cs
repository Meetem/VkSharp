using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeQualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeRateControlModeFlagsKHR preferredRateControlMode;
        public uint preferredRateControlLayerCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeQualityLevelPropertiesKHR Create()
        {
            VkVideoEncodeQualityLevelPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
