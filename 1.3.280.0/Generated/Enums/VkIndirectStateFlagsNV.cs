using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkIndirectStateFlagsNV : uint
    {
        VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = (uint)(0x00000001U),
        VK_INDIRECT_STATE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
