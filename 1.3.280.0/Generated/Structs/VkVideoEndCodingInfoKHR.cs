using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEndCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEndCodingFlagsKHR flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEndCodingInfoKHR Create()
        {
            VkVideoEndCodingInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
