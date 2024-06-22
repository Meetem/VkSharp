using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkLogicOp
    {
        VK_LOGIC_OP_CLEAR = (int)(0),
        VK_LOGIC_OP_AND = (int)(1),
        VK_LOGIC_OP_AND_REVERSE = (int)(2),
        VK_LOGIC_OP_COPY = (int)(3),
        VK_LOGIC_OP_AND_INVERTED = (int)(4),
        VK_LOGIC_OP_NO_OP = (int)(5),
        VK_LOGIC_OP_XOR = (int)(6),
        VK_LOGIC_OP_OR = (int)(7),
        VK_LOGIC_OP_NOR = (int)(8),
        VK_LOGIC_OP_EQUIVALENT = (int)(9),
        VK_LOGIC_OP_INVERT = (int)(10),
        VK_LOGIC_OP_OR_REVERSE = (int)(11),
        VK_LOGIC_OP_COPY_INVERTED = (int)(12),
        VK_LOGIC_OP_OR_INVERTED = (int)(13),
        VK_LOGIC_OP_NAND = (int)(14),
        VK_LOGIC_OP_SET = (int)(15),
        VK_LOGIC_OP_MAX_ENUM = (int)(2147483647),
    }
}
