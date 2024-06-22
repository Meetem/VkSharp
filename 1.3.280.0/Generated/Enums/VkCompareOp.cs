using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkCompareOp
    {
        VK_COMPARE_OP_NEVER = (int)(0),
        VK_COMPARE_OP_LESS = (int)(1),
        VK_COMPARE_OP_EQUAL = (int)(2),
        VK_COMPARE_OP_LESS_OR_EQUAL = (int)(3),
        VK_COMPARE_OP_GREATER = (int)(4),
        VK_COMPARE_OP_NOT_EQUAL = (int)(5),
        VK_COMPARE_OP_GREATER_OR_EQUAL = (int)(6),
        VK_COMPARE_OP_ALWAYS = (int)(7),
        VK_COMPARE_OP_MAX_ENUM = (int)(2147483647),
    }
}
