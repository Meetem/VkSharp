using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSamplerCreateFlagBits : uint
    {
        VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = (uint)(0x00000001U),
        VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = (uint)(0x00000002U),
        VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = (uint)(0x00000008U),
        VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT = (uint)(0x00000004U),
        VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM = (uint)(0x00000010U),
        VK_SAMPLER_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
