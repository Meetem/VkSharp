using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFlagsKHR flags;
        public VkBuffer dstBuffer;
        public ulong dstBufferOffset;
        public ulong dstBufferRange;
        public VkVideoPictureResourceInfoKHR srcPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public uint precedingExternallyEncodedBytes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeInfoKHR Create()
        {
            VkVideoEncodeInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
