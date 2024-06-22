using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkAccelerationStructureCreateFlagsKHR : uint
    {
        VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = (uint)(0x00000001U),
        VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV = (uint)(0x00000004U),
        VK_ACCELERATION_STRUCTURE_CREATE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
