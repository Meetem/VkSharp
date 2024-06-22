using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPresentModeKHR
    {
        VK_PRESENT_MODE_IMMEDIATE_KHR = (int)(0),
        VK_PRESENT_MODE_MAILBOX_KHR = (int)(1),
        VK_PRESENT_MODE_FIFO_KHR = (int)(2),
        VK_PRESENT_MODE_FIFO_RELAXED_KHR = (int)(3),
        VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = (int)(1000111000),
        VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = (int)(1000111001),
        VK_PRESENT_MODE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
