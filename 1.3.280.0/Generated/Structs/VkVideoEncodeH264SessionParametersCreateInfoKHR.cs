using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264SessionParametersCreateInfoKHR Create()
        {
            VkVideoEncodeH264SessionParametersCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
