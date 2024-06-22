using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkQueueGlobalPriorityKHR
    {
        VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = (int)(128),
        VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = (int)(256),
        VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = (int)(512),
        VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = (int)(1024),
        VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = (int)(128),
        VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = (int)(256),
        VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = (int)(512),
        VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = (int)(1024),
        VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM_KHR = (int)(2147483647),
    }
}
