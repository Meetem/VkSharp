using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkBufferUsageFlagBits : uint
    {
        VK_BUFFER_USAGE_TRANSFER_SRC_BIT = (uint)(0x00000001U),
        VK_BUFFER_USAGE_TRANSFER_DST_BIT = (uint)(0x00000002U),
        VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = (uint)(0x00000004U),
        VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = (uint)(0x00000008U),
        VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = (uint)(0x00000010U),
        VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = (uint)(0x00000020U),
        VK_BUFFER_USAGE_INDEX_BUFFER_BIT = (uint)(0x00000040U),
        VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = (uint)(0x00000080U),
        VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = (uint)(0x00000100U),
        VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT = (uint)(0x00020000U),
        VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR = (uint)(0x00002000U),
        VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR = (uint)(0x00004000U),
        VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = (uint)(0x00000800U),
        VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = (uint)(0x00001000U),
        VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = (uint)(0x00000200U),
        VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = (uint)(0x00080000U),
        VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = (uint)(0x00100000U),
        VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR = (uint)(0x00000400U),
        VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR = (uint)(0x00008000U),
        VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = (uint)(0x00010000U),
        VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = (uint)(0x00200000U),
        VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = (uint)(0x00400000U),
        VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = (uint)(0x04000000U),
        VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = (uint)(0x00800000U),
        VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT = (uint)(0x01000000U),
        VK_BUFFER_USAGE_RAY_TRACING_BIT_NV = (uint)(0x00000400U),
        VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT = (uint)(0x00020000U),
        VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR = (uint)(0x00020000U),
        VK_BUFFER_USAGE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
