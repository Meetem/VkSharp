using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMinQp;
        public VkVideoEncodeH264QpKHR minQp;
        public VkBool32 useMaxQp;
        public VkVideoEncodeH264QpKHR maxQp;
        public VkBool32 useMaxFrameSize;
        public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264RateControlLayerInfoKHR Create()
        {
            VkVideoEncodeH264RateControlLayerInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
