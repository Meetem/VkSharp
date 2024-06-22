using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265SessionParametersCreateInfoKHR Create()
        {
            VkVideoEncodeH265SessionParametersCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
