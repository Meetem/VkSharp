using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264CapabilityFlagsKHR flags;
        public StdVideoH264LevelIdc maxLevelIdc;
        public uint maxSliceCount;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxTemporalLayerCount;
        public VkBool32 expectDyadicTemporalLayerPattern;
        public int minQp;
        public int maxQp;
        public VkBool32 prefersGopRemainingFrames;
        public VkBool32 requiresGopRemainingFrames;
        public VkVideoEncodeH264StdFlagsKHR stdSyntaxFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264CapabilitiesKHR Create()
        {
            VkVideoEncodeH264CapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
