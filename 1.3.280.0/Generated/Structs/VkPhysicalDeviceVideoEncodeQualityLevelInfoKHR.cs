using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public uint qualityLevel;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR Create()
        {
            VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
