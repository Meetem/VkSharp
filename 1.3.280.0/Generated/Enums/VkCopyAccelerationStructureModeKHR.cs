using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkCopyAccelerationStructureModeKHR
    {
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = (int)(0),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = (int)(1),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = (int)(2),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = (int)(3),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = (int)(0),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = (int)(1),
        VK_COPY_ACCELERATION_STRUCTURE_MODE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
