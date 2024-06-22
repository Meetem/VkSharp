using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoEncodeH264GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoEncodeH264GopRemainingFrameInfoKHR Create()
        {
            VkVideoEncodeH264GopRemainingFrameInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
