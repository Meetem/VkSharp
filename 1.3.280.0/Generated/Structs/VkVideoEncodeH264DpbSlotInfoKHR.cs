using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264DpbSlotInfoKHR Create()
        {
            VkVideoEncodeH264DpbSlotInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
