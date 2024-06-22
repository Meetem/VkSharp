using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPerformanceCounterScopeKHR
    {
        VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = (int)(0),
        VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = (int)(1),
        VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = (int)(2),
        VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = (int)(0),
        VK_QUERY_SCOPE_RENDER_PASS_KHR = (int)(1),
        VK_QUERY_SCOPE_COMMAND_KHR = (int)(2),
        VK_PERFORMANCE_COUNTER_SCOPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
