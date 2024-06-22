using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkRenderingFlagBitsKHR : uint
    {
        VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR = (uint)(0x00000001U),
        VK_RENDERING_SUSPENDING_BIT_KHR = (uint)(0x00000002U),
        VK_RENDERING_RESUMING_BIT_KHR = (uint)(0x00000004U),
        VK_RENDERING_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
