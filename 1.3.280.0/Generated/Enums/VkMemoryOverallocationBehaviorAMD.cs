using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkMemoryOverallocationBehaviorAMD
    {
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = (int)(0),
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = (int)(1),
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = (int)(2),
        VK_MEMORY_OVERALLOCATION_BEHAVIOR_MAX_ENUM_AMD = (int)(2147483647),
    }
}
