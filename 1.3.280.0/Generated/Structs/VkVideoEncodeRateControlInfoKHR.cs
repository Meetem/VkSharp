using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeRateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeRateControlFlagsKHR flags;
        public VkVideoEncodeRateControlModeFlagsKHR rateControlMode;
        public uint layerCount;
        public VkVideoEncodeRateControlLayerInfoKHR* pLayers;
        public uint virtualBufferSizeInMs;
        public uint initialVirtualBufferSizeInMs;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeRateControlInfoKHR Create()
        {
            VkVideoEncodeRateControlInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
