using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeCapabilityFlagsKHR flags;
        public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;
        public uint maxRateControlLayers;
        public ulong maxBitrate;
        public uint maxQualityLevels;
        public VkExtent2D encodeInputPictureGranularity;
        public VkVideoEncodeFeedbackFlagsKHR supportedEncodeFeedbackFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeCapabilitiesKHR Create()
        {
            VkVideoEncodeCapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
