using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkRayTracingShaderGroupTypeKHR
    {
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = (int)(0),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = (int)(1),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = (int)(2),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = (int)(0),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = (int)(1),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = (int)(2),
        VK_RAY_TRACING_SHADER_GROUP_TYPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
