using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoH264PictureType
    {
        STD_VIDEO_H264_PICTURE_TYPE_P = (int)(0),
        STD_VIDEO_H264_PICTURE_TYPE_B = (int)(1),
        STD_VIDEO_H264_PICTURE_TYPE_I = (int)(2),
        STD_VIDEO_H264_PICTURE_TYPE_IDR = (int)(5),
        STD_VIDEO_H264_PICTURE_TYPE_INVALID = (int)(2147483647),
        STD_VIDEO_H264_PICTURE_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
