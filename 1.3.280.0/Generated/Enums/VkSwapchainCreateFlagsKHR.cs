using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSwapchainCreateFlagsKHR : uint
    {
        VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = (uint)(0x00000001U),
        VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = (uint)(0x00000002U),
        VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = (uint)(0x00000004U),
        VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT = (uint)(0x00000008U),
        VK_SWAPCHAIN_CREATE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
