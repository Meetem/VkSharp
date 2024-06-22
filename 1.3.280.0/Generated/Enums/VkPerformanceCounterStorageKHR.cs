using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPerformanceCounterStorageKHR
    {
        VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = (int)(0),
        VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = (int)(1),
        VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = (int)(2),
        VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = (int)(3),
        VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = (int)(4),
        VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = (int)(5),
        VK_PERFORMANCE_COUNTER_STORAGE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
