using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSemaphoreType
    {
        VK_SEMAPHORE_TYPE_BINARY = (int)(0),
        VK_SEMAPHORE_TYPE_TIMELINE = (int)(1),
        VK_SEMAPHORE_TYPE_BINARY_KHR = (int)(0),
        VK_SEMAPHORE_TYPE_TIMELINE_KHR = (int)(1),
        VK_SEMAPHORE_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
