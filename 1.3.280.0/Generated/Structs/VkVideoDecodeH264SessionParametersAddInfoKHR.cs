using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdSPSCount;
        public StdVideoH264SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH264PictureParameterSet* pStdPPSs;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH264SessionParametersAddInfoKHR Create()
        {
            VkVideoDecodeH264SessionParametersAddInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
