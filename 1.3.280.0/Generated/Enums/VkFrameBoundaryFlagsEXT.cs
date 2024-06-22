using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkFrameBoundaryFlagsEXT : uint
    {
        VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT = (uint)(0x00000001U),
        VK_FRAME_BOUNDARY_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
