using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkInstanceCreateFlagBits : uint
    {
        VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = (uint)(0x00000001U),
        VK_INSTANCE_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
