using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265DpbSlotInfoKHR Create()
        {
            VkVideoEncodeH265DpbSlotInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
