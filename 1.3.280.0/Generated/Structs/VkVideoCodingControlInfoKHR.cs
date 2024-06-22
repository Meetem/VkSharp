using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoCodingControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodingControlFlagsKHR flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoCodingControlInfoKHR Create()
        {
            VkVideoCodingControlInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
