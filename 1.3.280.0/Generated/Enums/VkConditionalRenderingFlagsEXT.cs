using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkConditionalRenderingFlagsEXT : uint
    {
        VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = (uint)(0x00000001U),
        VK_CONDITIONAL_RENDERING_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
