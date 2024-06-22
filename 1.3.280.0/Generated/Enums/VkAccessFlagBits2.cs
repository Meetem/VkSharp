using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkAccessFlagBits2 : ulong
    {
        VK_ACCESS_2_NONE = (ulong)(0x0000000000000000UL),
        VK_ACCESS_2_NONE_KHR = (ulong)(0x0000000000000000UL),
        VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = (ulong)(0x0000000000000001UL),
        VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = (ulong)(0x0000000000000001UL),
        VK_ACCESS_2_INDEX_READ_BIT = (ulong)(0x0000000000000002UL),
        VK_ACCESS_2_INDEX_READ_BIT_KHR = (ulong)(0x0000000000000002UL),
        VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = (ulong)(0x0000000000000004UL),
        VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = (ulong)(0x0000000000000004UL),
        VK_ACCESS_2_UNIFORM_READ_BIT = (ulong)(0x0000000000000008UL),
        VK_ACCESS_2_UNIFORM_READ_BIT_KHR = (ulong)(0x0000000000000008UL),
        VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = (ulong)(0x0000000000000010UL),
        VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = (ulong)(0x0000000000000010UL),
        VK_ACCESS_2_SHADER_READ_BIT = (ulong)(0x0000000000000020UL),
        VK_ACCESS_2_SHADER_READ_BIT_KHR = (ulong)(0x0000000000000020UL),
        VK_ACCESS_2_SHADER_WRITE_BIT = (ulong)(0x0000000000000040UL),
        VK_ACCESS_2_SHADER_WRITE_BIT_KHR = (ulong)(0x0000000000000040UL),
        VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = (ulong)(0x0000000000000080UL),
        VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = (ulong)(0x0000000000000080UL),
        VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = (ulong)(0x0000000000000100UL),
        VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = (ulong)(0x0000000000000100UL),
        VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = (ulong)(0x0000000000000200UL),
        VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = (ulong)(0x0000000000000200UL),
        VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = (ulong)(0x0000000000000400UL),
        VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = (ulong)(0x0000000000000400UL),
        VK_ACCESS_2_TRANSFER_READ_BIT = (ulong)(0x0000000000000800UL),
        VK_ACCESS_2_TRANSFER_READ_BIT_KHR = (ulong)(0x0000000000000800UL),
        VK_ACCESS_2_TRANSFER_WRITE_BIT = (ulong)(0x0000000000001000UL),
        VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = (ulong)(0x0000000000001000UL),
        VK_ACCESS_2_HOST_READ_BIT = (ulong)(0x0000000000002000UL),
        VK_ACCESS_2_HOST_READ_BIT_KHR = (ulong)(0x0000000000002000UL),
        VK_ACCESS_2_HOST_WRITE_BIT = (ulong)(0x0000000000004000UL),
        VK_ACCESS_2_HOST_WRITE_BIT_KHR = (ulong)(0x0000000000004000UL),
        VK_ACCESS_2_MEMORY_READ_BIT = (ulong)(0x0000000000008000UL),
        VK_ACCESS_2_MEMORY_READ_BIT_KHR = (ulong)(0x0000000000008000UL),
        VK_ACCESS_2_MEMORY_WRITE_BIT = (ulong)(0x0000000000010000UL),
        VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = (ulong)(0x0000000000010000UL),
        VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = (ulong)(0x0000000100000000UL),
        VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = (ulong)(0x0000000100000000UL),
        VK_ACCESS_2_SHADER_STORAGE_READ_BIT = (ulong)(0x0000000200000000UL),
        VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = (ulong)(0x0000000200000000UL),
        VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = (ulong)(0x0000000400000000UL),
        VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = (ulong)(0x0000000400000000UL),
        VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = (ulong)(0x0000000800000000UL),
        VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = (ulong)(0x0000001000000000UL),
        VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = (ulong)(0x0000002000000000UL),
        VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = (ulong)(0x0000004000000000UL),
        VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = (ulong)(0x0000000002000000UL),
        VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = (ulong)(0x0000000004000000UL),
        VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = (ulong)(0x0000000008000000UL),
        VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = (ulong)(0x0000000000100000UL),
        VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = (ulong)(0x0000000000020000UL),
        VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = (ulong)(0x0000000000040000UL),
        VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = (ulong)(0x0000000000800000UL),
        VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = (ulong)(0x0000000000800000UL),
        VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = (ulong)(0x0000000000200000UL),
        VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = (ulong)(0x0000000000400000UL),
        VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = (ulong)(0x0000000000200000UL),
        VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = (ulong)(0x0000000000400000UL),
        VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = (ulong)(0x0000000001000000UL),
        VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = (ulong)(0x0000000000080000UL),
        VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT = (ulong)(0x0000020000000000UL),
        VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = (ulong)(0x0000008000000000UL),
        VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR = (ulong)(0x0000010000000000UL),
        VK_ACCESS_2_MICROMAP_READ_BIT_EXT = (ulong)(0x0000100000000000UL),
        VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT = (ulong)(0x0000200000000000UL),
        VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV = (ulong)(0x0000040000000000UL),
        VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV = (ulong)(0x0000080000000000UL),
    }
}
