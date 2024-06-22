using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkRenderingFlagBits : uint
    {
        VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = (uint)(0x00000001U),
        VK_RENDERING_SUSPENDING_BIT = (uint)(0x00000002U),
        VK_RENDERING_RESUMING_BIT = (uint)(0x00000004U),
        VK_RENDERING_CONTENTS_INLINE_BIT_EXT = (uint)(0x00000010U),
        VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = (uint)(0x00000008U),
        VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR = (uint)(0x00000001U),
        VK_RENDERING_SUSPENDING_BIT_KHR = (uint)(0x00000002U),
        VK_RENDERING_RESUMING_BIT_KHR = (uint)(0x00000004U),
        VK_RENDERING_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
