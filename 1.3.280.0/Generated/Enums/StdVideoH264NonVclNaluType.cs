using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoH264NonVclNaluType
    {
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS = (int)(0),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS = (int)(1),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD = (int)(2),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX = (int)(3),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE = (int)(4),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM = (int)(5),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED = (int)(6),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_INVALID = (int)(2147483647),
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
