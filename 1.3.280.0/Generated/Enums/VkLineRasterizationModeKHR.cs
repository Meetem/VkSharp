using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkLineRasterizationModeKHR
    {
        VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR = (int)(0),
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR = (int)(1),
        VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR = (int)(2),
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR = (int)(3),
        VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = (int)(0),
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = (int)(1),
        VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = (int)(2),
        VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = (int)(3),
        VK_LINE_RASTERIZATION_MODE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
