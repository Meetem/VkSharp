using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkAttachmentLoadOp
    {
        VK_ATTACHMENT_LOAD_OP_LOAD = (int)(0),
        VK_ATTACHMENT_LOAD_OP_CLEAR = (int)(1),
        VK_ATTACHMENT_LOAD_OP_DONT_CARE = (int)(2),
        VK_ATTACHMENT_LOAD_OP_NONE_KHR = (int)(1000400000),
        VK_ATTACHMENT_LOAD_OP_NONE_EXT = (int)(1000400000),
        VK_ATTACHMENT_LOAD_OP_MAX_ENUM = (int)(2147483647),
    }
}
