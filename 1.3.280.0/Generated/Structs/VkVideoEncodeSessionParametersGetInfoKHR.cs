using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeSessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersKHR videoSessionParameters;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeSessionParametersGetInfoKHR Create()
        {
            VkVideoEncodeSessionParametersGetInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
