using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPerformanceCounterUnitKHR
    {
        VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR = (int)(0),
        VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR = (int)(1),
        VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR = (int)(2),
        VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR = (int)(3),
        VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR = (int)(4),
        VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR = (int)(5),
        VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR = (int)(6),
        VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR = (int)(7),
        VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR = (int)(8),
        VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR = (int)(9),
        VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR = (int)(10),
        VK_PERFORMANCE_COUNTER_UNIT_MAX_ENUM_KHR = (int)(2147483647),
    }
}
