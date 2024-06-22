using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkAttachmentDescriptionFlagBits : uint
    {
        VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = (uint)(0x00000001U),
        VK_ATTACHMENT_DESCRIPTION_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
