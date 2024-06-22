using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMicromapBuildInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapTypeEXT type;
        public VkBuildMicromapFlagsEXT flags;
        public VkBuildMicromapModeEXT mode;
        public VkMicromapEXT dstMicromap;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkDeviceOrHostAddressConstKHR data;
        public VkDeviceOrHostAddressKHR scratchData;
        public VkDeviceOrHostAddressConstKHR triangleArray;
        public ulong triangleArrayStride;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMicromapBuildInfoEXT Create()
        {
            VkMicromapBuildInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
