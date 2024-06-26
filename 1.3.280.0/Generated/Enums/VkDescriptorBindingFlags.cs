using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDescriptorBindingFlags : uint
    {
        VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT = (uint)(0x00000001U),
        VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT = (uint)(0x00000002U),
        VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT = (uint)(0x00000004U),
        VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT = (uint)(0x00000008U),
        VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT = (uint)(0x00000001U),
        VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = (uint)(0x00000002U),
        VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT = (uint)(0x00000004U),
        VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT = (uint)(0x00000008U),
        VK_DESCRIPTOR_BINDING_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
