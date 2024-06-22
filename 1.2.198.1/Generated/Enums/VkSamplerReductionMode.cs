using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSamplerReductionMode
    {
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = (int)(0),
        VK_SAMPLER_REDUCTION_MODE_MIN = (int)(1),
        VK_SAMPLER_REDUCTION_MODE_MAX = (int)(2),
        VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = (int)(0),
        VK_SAMPLER_REDUCTION_MODE_MIN_EXT = (int)(1),
        VK_SAMPLER_REDUCTION_MODE_MAX_EXT = (int)(2),
        VK_SAMPLER_REDUCTION_MODE_MAX_ENUM = (int)(2147483647),
    }
}
