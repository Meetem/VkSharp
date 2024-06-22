using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoAV1FrameType
    {
        STD_VIDEO_AV1_FRAME_TYPE_KEY = (int)(0),
        STD_VIDEO_AV1_FRAME_TYPE_INTER = (int)(1),
        STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY = (int)(2),
        STD_VIDEO_AV1_FRAME_TYPE_SWITCH = (int)(3),
        STD_VIDEO_AV1_FRAME_TYPE_INVALID = (int)(2147483647),
        STD_VIDEO_AV1_FRAME_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
