using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkIndexType
    {
        VK_INDEX_TYPE_UINT16 = (int)(0),
        VK_INDEX_TYPE_UINT32 = (int)(1),
        VK_INDEX_TYPE_NONE_KHR = (int)(1000165000),
        VK_INDEX_TYPE_UINT8_KHR = (int)(1000265000),
        VK_INDEX_TYPE_NONE_NV = (int)(1000165000),
        VK_INDEX_TYPE_UINT8_EXT = (int)(1000265000),
        VK_INDEX_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
