using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoBeginCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoBeginCodingFlagsKHR flags;
        public VkVideoSessionKHR videoSession;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoBeginCodingInfoKHR Create()
        {
            VkVideoBeginCodingInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
