using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoAV1FrameRestorationType
    {
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE = (int)(0),
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER = (int)(1),
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ = (int)(2),
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE = (int)(3),
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_INVALID = (int)(2147483647),
        STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
