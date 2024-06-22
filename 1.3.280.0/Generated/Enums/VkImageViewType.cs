using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkImageViewType
    {
        VK_IMAGE_VIEW_TYPE_1D = (int)(0),
        VK_IMAGE_VIEW_TYPE_2D = (int)(1),
        VK_IMAGE_VIEW_TYPE_3D = (int)(2),
        VK_IMAGE_VIEW_TYPE_CUBE = (int)(3),
        VK_IMAGE_VIEW_TYPE_1D_ARRAY = (int)(4),
        VK_IMAGE_VIEW_TYPE_2D_ARRAY = (int)(5),
        VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = (int)(6),
        VK_IMAGE_VIEW_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
