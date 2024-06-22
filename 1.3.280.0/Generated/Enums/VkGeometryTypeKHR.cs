using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkGeometryTypeKHR
    {
        VK_GEOMETRY_TYPE_TRIANGLES_KHR = (int)(0),
        VK_GEOMETRY_TYPE_AABBS_KHR = (int)(1),
        VK_GEOMETRY_TYPE_INSTANCES_KHR = (int)(2),
        VK_GEOMETRY_TYPE_TRIANGLES_NV = (int)(0),
        VK_GEOMETRY_TYPE_AABBS_NV = (int)(1),
        VK_GEOMETRY_TYPE_MAX_ENUM_KHR = (int)(2147483647),
    }
}
