using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSamplerCreateFlags : uint
    {
        VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = (uint)(0x00000001U),
        VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = (uint)(0x00000002U),
        VK_SAMPLER_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
