using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeFlagsKHR flags;
        public VkBuffer srcBuffer;
        public ulong srcBufferOffset;
        public ulong srcBufferRange;
        public VkVideoPictureResourceInfoKHR dstPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeInfoKHR Create()
        {
            VkVideoDecodeInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
