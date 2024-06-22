using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkFramebufferCreateFlags : uint
    {
        VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = (uint)(0x00000001U),
        VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR = (uint)(0x00000001U),
        VK_FRAMEBUFFER_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
