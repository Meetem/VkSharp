using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDependencyFlags : uint
    {
        VK_DEPENDENCY_BY_REGION_BIT = (uint)(0x00000001U),
        VK_DEPENDENCY_DEVICE_GROUP_BIT = (uint)(0x00000004U),
        VK_DEPENDENCY_VIEW_LOCAL_BIT = (uint)(0x00000002U),
        VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = (uint)(0x00000008U),
        VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = (uint)(0x00000002U),
        VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = (uint)(0x00000004U),
        VK_DEPENDENCY_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
