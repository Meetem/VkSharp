using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkFenceCreateFlagBits : uint
    {
        VK_FENCE_CREATE_SIGNALED_BIT = (uint)(0x00000001U),
        VK_FENCE_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
