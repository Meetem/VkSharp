using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkPointClippingBehavior
    {
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = (int)(0),
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = (int)(1),
        VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR = (int)(0),
        VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR = (int)(1),
        VK_POINT_CLIPPING_BEHAVIOR_MAX_ENUM = (int)(2147483647),
    }
}
