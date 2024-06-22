using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVideoFormatInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags imageUsage;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVideoFormatInfoKHR Create()
        {
            VkPhysicalDeviceVideoFormatInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
