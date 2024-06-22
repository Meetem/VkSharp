using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkAccelerationStructureTypeKHR
    {
        VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR = (int)(0),
        VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR = (int)(1),
        VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR = (int)(2),
        VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = (int)(0),
        VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV = (int)(1),
        VK_ACCELERATION_STRUCTURE_TYPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
