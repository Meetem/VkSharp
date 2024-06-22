using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoAV1InterpolationFilter
    {
        STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP = (int)(0),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH = (int)(1),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SHARP = (int)(2),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_BILINEAR = (int)(3),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_SWITCHABLE = (int)(4),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_INVALID = (int)(2147483647),
        STD_VIDEO_AV1_INTERPOLATION_FILTER_MAX_ENUM = (int)(2147483647),
    }
}
