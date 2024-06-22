using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkDescriptorType
    {
        VK_DESCRIPTOR_TYPE_SAMPLER = (int)(0),
        VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = (int)(1),
        VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = (int)(2),
        VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = (int)(3),
        VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = (int)(4),
        VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = (int)(5),
        VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = (int)(6),
        VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = (int)(7),
        VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = (int)(8),
        VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = (int)(9),
        VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = (int)(10),
        VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK = (int)(1000138000),
        VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR = (int)(1000150000),
        VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = (int)(1000165000),
        VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM = (int)(1000440000),
        VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM = (int)(1000440001),
        VK_DESCRIPTOR_TYPE_MUTABLE_EXT = (int)(1000351000),
        VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT = (int)(1000138000),
        VK_DESCRIPTOR_TYPE_MUTABLE_VALVE = (int)(1000351000),
        VK_DESCRIPTOR_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
