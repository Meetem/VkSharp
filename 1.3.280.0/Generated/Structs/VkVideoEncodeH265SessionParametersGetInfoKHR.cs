using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265SessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 writeStdVPS;
        public VkBool32 writeStdSPS;
        public VkBool32 writeStdPPS;
        public uint stdVPSId;
        public uint stdSPSId;
        public uint stdPPSId;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265SessionParametersGetInfoKHR Create()
        {
            VkVideoEncodeH265SessionParametersGetInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
