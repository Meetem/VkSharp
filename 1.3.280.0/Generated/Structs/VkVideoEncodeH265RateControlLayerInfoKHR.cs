using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMinQp;
        public VkVideoEncodeH265QpKHR minQp;
        public VkBool32 useMaxQp;
        public VkVideoEncodeH265QpKHR maxQp;
        public VkBool32 useMaxFrameSize;
        public VkVideoEncodeH265FrameSizeKHR maxFrameSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH265RateControlLayerInfoKHR Create()
        {
            VkVideoEncodeH265RateControlLayerInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
