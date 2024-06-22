using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265CapabilityFlagsKHR flags;
        public StdVideoH265LevelIdc maxLevelIdc;
        public uint maxSliceSegmentCount;
        public VkExtent2D maxTiles;
        public VkVideoEncodeH265CtbSizeFlagsKHR ctbSizes;
        public VkVideoEncodeH265TransformBlockSizeFlagsKHR transformBlockSizes;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxSubLayerCount;
        public VkBool32 expectDyadicTemporalSubLayerPattern;
        public int minQp;
        public int maxQp;
        public VkBool32 prefersGopRemainingFrames;
        public VkBool32 requiresGopRemainingFrames;
        public VkVideoEncodeH265StdFlagsKHR stdSyntaxFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265CapabilitiesKHR Create()
        {
            VkVideoEncodeH265CapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
