using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDeviceGroupPresentModeFlagsKHR : uint
    {
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = (uint)(0x00000001U),
        VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = (uint)(0x00000002U),
        VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = (uint)(0x00000004U),
        VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = (uint)(0x00000008U),
        VK_DEVICE_GROUP_PRESENT_MODE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
