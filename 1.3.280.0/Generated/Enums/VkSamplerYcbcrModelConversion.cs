using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSamplerYcbcrModelConversion
    {
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = (int)(0),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = (int)(1),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = (int)(2),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = (int)(3),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = (int)(4),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY_KHR = (int)(0),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY_KHR = (int)(1),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709_KHR = (int)(2),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601_KHR = (int)(3),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020_KHR = (int)(4),
        VK_SAMPLER_YCBCR_MODEL_CONVERSION_MAX_ENUM = (int)(2147483647),
    }
}
