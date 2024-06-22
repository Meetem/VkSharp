using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdVPSCount;
        public StdVideoH265VideoParameterSet* pStdVPSs;
        public uint stdSPSCount;
        public StdVideoH265SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH265PictureParameterSet* pStdPPSs;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265SessionParametersAddInfoKHR Create()
        {
            VkVideoEncodeH265SessionParametersAddInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
