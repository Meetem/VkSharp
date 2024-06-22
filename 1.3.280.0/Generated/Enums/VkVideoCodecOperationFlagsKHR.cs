using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoCodecOperationFlagsKHR : uint
    {
        VK_VIDEO_CODEC_OPERATION_NONE_KHR = (uint)(0x00000000U),
        VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR = (uint)(0x00010000U),
        VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR = (uint)(0x00020000U),
        VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_CODEC_OPERATION_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
