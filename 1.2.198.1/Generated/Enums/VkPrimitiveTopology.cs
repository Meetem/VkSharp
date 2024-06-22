using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPrimitiveTopology
    {
        VK_PRIMITIVE_TOPOLOGY_POINT_LIST = (int)(0),
        VK_PRIMITIVE_TOPOLOGY_LINE_LIST = (int)(1),
        VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = (int)(2),
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = (int)(3),
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = (int)(4),
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = (int)(5),
        VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = (int)(6),
        VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = (int)(7),
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = (int)(8),
        VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = (int)(9),
        VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = (int)(10),
        VK_PRIMITIVE_TOPOLOGY_MAX_ENUM = (int)(2147483647),
    }
}
