using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSurfaceCounterFlagsEXT : uint
    {
        VK_SURFACE_COUNTER_VBLANK_BIT_EXT = (uint)(0x00000001U),
        VK_SURFACE_COUNTER_VBLANK_EXT = (uint)(0x00000001U),
        VK_SURFACE_COUNTER_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
