using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkShaderStageFlags : uint
    {
        VK_SHADER_STAGE_VERTEX_BIT = (uint)(0x00000001U),
        VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = (uint)(0x00000002U),
        VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = (uint)(0x00000004U),
        VK_SHADER_STAGE_GEOMETRY_BIT = (uint)(0x00000008U),
        VK_SHADER_STAGE_FRAGMENT_BIT = (uint)(0x00000010U),
        VK_SHADER_STAGE_COMPUTE_BIT = (uint)(0x00000020U),
        VK_SHADER_STAGE_ALL_GRAPHICS = (uint)(0x0000001FU),
        VK_SHADER_STAGE_ALL = (uint)(0x7FFFFFFFU),
        VK_SHADER_STAGE_RAYGEN_BIT_KHR = (uint)(0x00000100U),
        VK_SHADER_STAGE_ANY_HIT_BIT_KHR = (uint)(0x00000200U),
        VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR = (uint)(0x00000400U),
        VK_SHADER_STAGE_MISS_BIT_KHR = (uint)(0x00000800U),
        VK_SHADER_STAGE_INTERSECTION_BIT_KHR = (uint)(0x00001000U),
        VK_SHADER_STAGE_CALLABLE_BIT_KHR = (uint)(0x00002000U),
        VK_SHADER_STAGE_TASK_BIT_EXT = (uint)(0x00000040U),
        VK_SHADER_STAGE_MESH_BIT_EXT = (uint)(0x00000080U),
        VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI = (uint)(0x00004000U),
        VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI = (uint)(0x00080000U),
        VK_SHADER_STAGE_RAYGEN_BIT_NV = (uint)(0x00000100U),
        VK_SHADER_STAGE_ANY_HIT_BIT_NV = (uint)(0x00000200U),
        VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV = (uint)(0x00000400U),
        VK_SHADER_STAGE_MISS_BIT_NV = (uint)(0x00000800U),
        VK_SHADER_STAGE_INTERSECTION_BIT_NV = (uint)(0x00001000U),
        VK_SHADER_STAGE_CALLABLE_BIT_NV = (uint)(0x00002000U),
        VK_SHADER_STAGE_TASK_BIT_NV = (uint)(0x00000040U),
        VK_SHADER_STAGE_MESH_BIT_NV = (uint)(0x00000080U),
        VK_SHADER_STAGE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
