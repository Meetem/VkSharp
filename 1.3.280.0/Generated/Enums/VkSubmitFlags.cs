using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSubmitFlags : uint
    {
        VK_SUBMIT_PROTECTED_BIT = (uint)(0x00000001U),
        VK_SUBMIT_PROTECTED_BIT_KHR = (uint)(0x00000001U),
        VK_SUBMIT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
