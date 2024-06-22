using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSubpassContents
    {
        VK_SUBPASS_CONTENTS_INLINE = (int)(0),
        VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = (int)(1),
        VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_EXT = (int)(1000451000),
        VK_SUBPASS_CONTENTS_MAX_ENUM = (int)(2147483647),
    }
}
