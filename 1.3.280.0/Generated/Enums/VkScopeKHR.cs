using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkScopeKHR
    {
        VK_SCOPE_DEVICE_KHR = (int)(1),
        VK_SCOPE_WORKGROUP_KHR = (int)(2),
        VK_SCOPE_SUBGROUP_KHR = (int)(3),
        VK_SCOPE_QUEUE_FAMILY_KHR = (int)(5),
        VK_SCOPE_DEVICE_NV = (int)(1),
        VK_SCOPE_WORKGROUP_NV = (int)(2),
        VK_SCOPE_SUBGROUP_NV = (int)(3),
        VK_SCOPE_QUEUE_FAMILY_NV = (int)(5),
        VK_SCOPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
