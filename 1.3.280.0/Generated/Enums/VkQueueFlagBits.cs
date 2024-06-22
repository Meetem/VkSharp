using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkQueueFlagBits : uint
    {
        VK_QUEUE_GRAPHICS_BIT = (uint)(0x00000001U),
        VK_QUEUE_COMPUTE_BIT = (uint)(0x00000002U),
        VK_QUEUE_TRANSFER_BIT = (uint)(0x00000004U),
        VK_QUEUE_SPARSE_BINDING_BIT = (uint)(0x00000008U),
        VK_QUEUE_PROTECTED_BIT = (uint)(0x00000010U),
        VK_QUEUE_VIDEO_DECODE_BIT_KHR = (uint)(0x00000020U),
        VK_QUEUE_VIDEO_ENCODE_BIT_KHR = (uint)(0x00000040U),
        VK_QUEUE_OPTICAL_FLOW_BIT_NV = (uint)(0x00000100U),
        VK_QUEUE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
