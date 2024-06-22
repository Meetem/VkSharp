using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeSessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasOverrides;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeSessionParametersFeedbackInfoKHR Create()
        {
            VkVideoEncodeSessionParametersFeedbackInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
