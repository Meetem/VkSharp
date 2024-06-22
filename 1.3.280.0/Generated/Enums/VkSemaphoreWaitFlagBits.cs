using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSemaphoreWaitFlagBits : uint
    {
        VK_SEMAPHORE_WAIT_ANY_BIT = (uint)(0x00000001U),
        VK_SEMAPHORE_WAIT_ANY_BIT_KHR = (uint)(0x00000001U),
        VK_SEMAPHORE_WAIT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
