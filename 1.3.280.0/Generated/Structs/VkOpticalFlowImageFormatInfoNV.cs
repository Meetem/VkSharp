using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkOpticalFlowImageFormatInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowUsageFlagsNV usage;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkOpticalFlowImageFormatInfoNV Create()
        {
            VkOpticalFlowImageFormatInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
