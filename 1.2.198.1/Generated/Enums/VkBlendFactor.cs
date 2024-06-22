using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkBlendFactor
    {
        VK_BLEND_FACTOR_ZERO = (int)(0),
        VK_BLEND_FACTOR_ONE = (int)(1),
        VK_BLEND_FACTOR_SRC_COLOR = (int)(2),
        VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = (int)(3),
        VK_BLEND_FACTOR_DST_COLOR = (int)(4),
        VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = (int)(5),
        VK_BLEND_FACTOR_SRC_ALPHA = (int)(6),
        VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = (int)(7),
        VK_BLEND_FACTOR_DST_ALPHA = (int)(8),
        VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = (int)(9),
        VK_BLEND_FACTOR_CONSTANT_COLOR = (int)(10),
        VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = (int)(11),
        VK_BLEND_FACTOR_CONSTANT_ALPHA = (int)(12),
        VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = (int)(13),
        VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = (int)(14),
        VK_BLEND_FACTOR_SRC1_COLOR = (int)(15),
        VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = (int)(16),
        VK_BLEND_FACTOR_SRC1_ALPHA = (int)(17),
        VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = (int)(18),
        VK_BLEND_FACTOR_MAX_ENUM = (int)(2147483647),
    }
}
