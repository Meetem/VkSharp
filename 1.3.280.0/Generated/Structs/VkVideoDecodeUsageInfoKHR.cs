using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeUsageFlagsKHR videoUsageHints;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeUsageInfoKHR Create()
        {
            VkVideoDecodeUsageInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
