using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkImageTiling
    {
        VK_IMAGE_TILING_OPTIMAL = (int)(0),
        VK_IMAGE_TILING_LINEAR = (int)(1),
        VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = (int)(1000158000),
        VK_IMAGE_TILING_MAX_ENUM = (int)(2147483647),
    }
}
