using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkImageCompressionFlagBitsEXT : uint
    {
        VK_IMAGE_COMPRESSION_DEFAULT_EXT = (uint)(0x00000000U),
        VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT = (uint)(0x00000001U),
        VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT = (uint)(0x00000002U),
        VK_IMAGE_COMPRESSION_DISABLED_EXT = (uint)(0x00000004U),
        VK_IMAGE_COMPRESSION_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
