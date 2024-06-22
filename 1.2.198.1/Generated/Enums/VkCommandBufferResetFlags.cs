using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkCommandBufferResetFlags : uint
    {
        VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = (uint)(0x00000001U),
        VK_COMMAND_BUFFER_RESET_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
