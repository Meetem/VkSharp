using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkStencilOp
    {
        VK_STENCIL_OP_KEEP = (int)(0),
        VK_STENCIL_OP_ZERO = (int)(1),
        VK_STENCIL_OP_REPLACE = (int)(2),
        VK_STENCIL_OP_INCREMENT_AND_CLAMP = (int)(3),
        VK_STENCIL_OP_DECREMENT_AND_CLAMP = (int)(4),
        VK_STENCIL_OP_INVERT = (int)(5),
        VK_STENCIL_OP_INCREMENT_AND_WRAP = (int)(6),
        VK_STENCIL_OP_DECREMENT_AND_WRAP = (int)(7),
        VK_STENCIL_OP_MAX_ENUM = (int)(2147483647),
    }
}
