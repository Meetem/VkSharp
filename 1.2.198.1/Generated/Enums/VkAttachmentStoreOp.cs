using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkAttachmentStoreOp
    {
        VK_ATTACHMENT_STORE_OP_STORE = (int)(0),
        VK_ATTACHMENT_STORE_OP_DONT_CARE = (int)(1),
        VK_ATTACHMENT_STORE_OP_NONE_KHR = (int)(1000301000),
        VK_ATTACHMENT_STORE_OP_NONE_QCOM = (int)(1000301000),
        VK_ATTACHMENT_STORE_OP_NONE_EXT = (int)(1000301000),
        VK_ATTACHMENT_STORE_OP_MAX_ENUM = (int)(2147483647),
    }
}
