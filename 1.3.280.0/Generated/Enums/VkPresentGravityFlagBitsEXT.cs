using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkPresentGravityFlagBitsEXT : uint
    {
        VK_PRESENT_GRAVITY_MIN_BIT_EXT = (uint)(0x00000001U),
        VK_PRESENT_GRAVITY_MAX_BIT_EXT = (uint)(0x00000002U),
        VK_PRESENT_GRAVITY_CENTERED_BIT_EXT = (uint)(0x00000004U),
        VK_PRESENT_GRAVITY_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
