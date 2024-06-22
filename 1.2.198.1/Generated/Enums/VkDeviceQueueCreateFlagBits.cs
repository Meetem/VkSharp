using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDeviceQueueCreateFlagBits : uint
    {
        VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = (uint)(0x00000001U),
        VK_DEVICE_QUEUE_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
