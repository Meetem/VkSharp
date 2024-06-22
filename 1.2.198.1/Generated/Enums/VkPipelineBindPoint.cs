using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPipelineBindPoint
    {
        VK_PIPELINE_BIND_POINT_GRAPHICS = (int)(0),
        VK_PIPELINE_BIND_POINT_COMPUTE = (int)(1),
        VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR = (int)(1000165000),
        VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI = (int)(1000369003),
        VK_PIPELINE_BIND_POINT_RAY_TRACING_NV = (int)(1000165000),
        VK_PIPELINE_BIND_POINT_MAX_ENUM = (int)(2147483647),
    }
}
