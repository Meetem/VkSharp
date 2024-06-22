using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkTimeDomainKHR
    {
        VK_TIME_DOMAIN_DEVICE_KHR = (int)(0),
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR = (int)(1),
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR = (int)(2),
        VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR = (int)(3),
        VK_TIME_DOMAIN_DEVICE_EXT = (int)(0),
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = (int)(1),
        VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = (int)(2),
        VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = (int)(3),
        VK_TIME_DOMAIN_MAX_ENUM_KHR = (int)(2147483647),
    }
}
