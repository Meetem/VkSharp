using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSharingMode
    {
        VK_SHARING_MODE_EXCLUSIVE = (int)(0),
        VK_SHARING_MODE_CONCURRENT = (int)(1),
        VK_SHARING_MODE_MAX_ENUM = (int)(2147483647),
    }
}
