using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDeviceAddressBindingFlagBitsEXT : uint
    {
        VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT = (uint)(0x00000001U),
        VK_DEVICE_ADDRESS_BINDING_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
