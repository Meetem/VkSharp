using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoReferenceSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int slotIndex;
        public VkVideoPictureResourceInfoKHR* pPictureResource;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoReferenceSlotInfoKHR Create()
        {
            VkVideoReferenceSlotInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
