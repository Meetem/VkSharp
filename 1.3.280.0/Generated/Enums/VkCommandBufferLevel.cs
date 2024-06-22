using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkCommandBufferLevel
    {
        VK_COMMAND_BUFFER_LEVEL_PRIMARY = (int)(0),
        VK_COMMAND_BUFFER_LEVEL_SECONDARY = (int)(1),
        VK_COMMAND_BUFFER_LEVEL_MAX_ENUM = (int)(2147483647),
    }
}
