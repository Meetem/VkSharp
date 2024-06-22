using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasStdSPSOverrides;
        public VkBool32 hasStdPPSOverrides;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264SessionParametersFeedbackInfoKHR Create()
        {
            VkVideoEncodeH264SessionParametersFeedbackInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
