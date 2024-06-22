using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDescriptorPoolCreateFlags : uint
    {
        VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = (uint)(0x00000001U),
        VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = (uint)(0x00000002U),
        VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = (uint)(0x00000004U),
        VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT = (uint)(0x00000002U),
        VK_DESCRIPTOR_POOL_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
