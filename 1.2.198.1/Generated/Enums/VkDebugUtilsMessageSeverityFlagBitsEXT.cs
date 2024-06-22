using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagBitsEXT : uint
    {
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = (uint)(0x00000001U),
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = (uint)(0x00000010U),
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = (uint)(0x00000100U),
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = (uint)(0x00001000U),
        VK_DEBUG_UTILS_MESSAGE_SEVERITY_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
