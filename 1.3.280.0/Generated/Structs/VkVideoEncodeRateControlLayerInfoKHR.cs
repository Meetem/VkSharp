using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeRateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong averageBitrate;
        public ulong maxBitrate;
        public uint frameRateNumerator;
        public uint frameRateDenominator;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeRateControlLayerInfoKHR Create()
        {
            VkVideoEncodeRateControlLayerInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
