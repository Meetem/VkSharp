using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT : uint
    {
        VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT = (uint)(0x00000001U),
        VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT = (uint)(0x00000002U),
        VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT = (uint)(0x00000004U),
        VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT = (uint)(0x00000008U),
        VK_DEBUG_UTILS_MESSAGE_TYPE_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
