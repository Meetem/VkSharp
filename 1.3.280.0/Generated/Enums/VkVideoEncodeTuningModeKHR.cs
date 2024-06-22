using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkVideoEncodeTuningModeKHR
    {
        VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR = (int)(0),
        VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR = (int)(1),
        VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR = (int)(2),
        VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR = (int)(3),
        VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR = (int)(4),
        VK_VIDEO_ENCODE_TUNING_MODE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
