using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkBufferCreateFlagBits : uint
    {
        VK_BUFFER_CREATE_SPARSE_BINDING_BIT = (uint)(0x00000001U),
        VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = (uint)(0x00000002U),
        VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = (uint)(0x00000004U),
        VK_BUFFER_CREATE_PROTECTED_BIT = (uint)(0x00000008U),
        VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = (uint)(0x00000010U),
        VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = (uint)(0x00000010U),
        VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = (uint)(0x00000010U),
        VK_BUFFER_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
