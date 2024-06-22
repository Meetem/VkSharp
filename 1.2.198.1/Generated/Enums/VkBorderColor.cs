using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkBorderColor
    {
        VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = (int)(0),
        VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = (int)(1),
        VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = (int)(2),
        VK_BORDER_COLOR_INT_OPAQUE_BLACK = (int)(3),
        VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = (int)(4),
        VK_BORDER_COLOR_INT_OPAQUE_WHITE = (int)(5),
        VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = (int)(1000287003),
        VK_BORDER_COLOR_INT_CUSTOM_EXT = (int)(1000287004),
        VK_BORDER_COLOR_MAX_ENUM = (int)(2147483647),
    }
}
