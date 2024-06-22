using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkCommandPoolCreateFlags : uint
    {
        VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = (uint)(0x00000001U),
        VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = (uint)(0x00000002U),
        VK_COMMAND_POOL_CREATE_PROTECTED_BIT = (uint)(0x00000004U),
        VK_COMMAND_POOL_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
