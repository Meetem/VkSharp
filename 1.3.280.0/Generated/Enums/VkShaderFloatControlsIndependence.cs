using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkShaderFloatControlsIndependence
    {
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = (int)(0),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = (int)(1),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = (int)(2),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY_KHR = (int)(0),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL_KHR = (int)(1),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE_KHR = (int)(2),
        VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_MAX_ENUM = (int)(2147483647),
    }
}
