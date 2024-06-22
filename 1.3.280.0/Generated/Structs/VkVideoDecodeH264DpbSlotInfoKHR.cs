using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeH264DpbSlotInfoKHR Create()
        {
            VkVideoDecodeH264DpbSlotInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
