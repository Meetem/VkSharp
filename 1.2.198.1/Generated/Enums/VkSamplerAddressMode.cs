using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSamplerAddressMode
    {
        VK_SAMPLER_ADDRESS_MODE_REPEAT = (int)(0),
        VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = (int)(1),
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = (int)(2),
        VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = (int)(3),
        VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = (int)(4),
        VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR = (int)(4),
        VK_SAMPLER_ADDRESS_MODE_MAX_ENUM = (int)(2147483647),
    }
}
