using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPhysicalDeviceType
    {
        VK_PHYSICAL_DEVICE_TYPE_OTHER = (int)(0),
        VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = (int)(1),
        VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = (int)(2),
        VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = (int)(3),
        VK_PHYSICAL_DEVICE_TYPE_CPU = (int)(4),
        VK_PHYSICAL_DEVICE_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
