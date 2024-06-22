using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkAccelerationStructureBuildTypeKHR
    {
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = (int)(0),
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = (int)(1),
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = (int)(2),
        VK_ACCELERATION_STRUCTURE_BUILD_TYPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
