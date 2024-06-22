using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeUsageFlagsKHR videoUsageHints;
        public VkVideoEncodeContentFlagsKHR videoContentHints;
        public VkVideoEncodeTuningModeKHR tuningMode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeUsageInfoKHR Create()
        {
            VkVideoEncodeUsageInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
