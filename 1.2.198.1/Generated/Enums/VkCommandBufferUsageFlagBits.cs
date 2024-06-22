using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkCommandBufferUsageFlagBits : uint
    {
        VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = (uint)(0x00000001U),
        VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = (uint)(0x00000002U),
        VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = (uint)(0x00000004U),
        VK_COMMAND_BUFFER_USAGE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
