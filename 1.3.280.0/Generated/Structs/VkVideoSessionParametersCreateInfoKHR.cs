using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoSessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersCreateFlagsKHR flags;
        public VkVideoSessionParametersKHR videoSessionParametersTemplate;
        public VkVideoSessionKHR videoSession;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoSessionParametersCreateInfoKHR Create()
        {
            VkVideoSessionParametersCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
