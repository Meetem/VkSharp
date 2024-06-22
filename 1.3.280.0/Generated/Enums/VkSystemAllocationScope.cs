using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSystemAllocationScope
    {
        VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = (int)(0),
        VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = (int)(1),
        VK_SYSTEM_ALLOCATION_SCOPE_CACHE = (int)(2),
        VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = (int)(3),
        VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = (int)(4),
        VK_SYSTEM_ALLOCATION_SCOPE_MAX_ENUM = (int)(2147483647),
    }
}
