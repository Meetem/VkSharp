using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkFilter
    {
        VK_FILTER_NEAREST = (int)(0),
        VK_FILTER_LINEAR = (int)(1),
        VK_FILTER_CUBIC_EXT = (int)(1000015000),
        VK_FILTER_CUBIC_IMG = (int)(1000015000),
        VK_FILTER_MAX_ENUM = (int)(2147483647),
    }
}
