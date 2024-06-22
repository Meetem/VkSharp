using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkEventCreateFlagBits : uint
    {
        VK_EVENT_CREATE_DEVICE_ONLY_BIT_KHR = (uint)(0x00000001U),
        VK_EVENT_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
