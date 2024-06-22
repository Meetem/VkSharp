using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFeedbackFlagsKHR encodeFeedbackFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueryPoolVideoEncodeFeedbackCreateInfoKHR Create()
        {
            VkQueryPoolVideoEncodeFeedbackCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
