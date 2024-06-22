using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkLayerSettingTypeEXT
    {
        VK_LAYER_SETTING_TYPE_BOOL32_EXT = (int)(0),
        VK_LAYER_SETTING_TYPE_INT32_EXT = (int)(1),
        VK_LAYER_SETTING_TYPE_INT64_EXT = (int)(2),
        VK_LAYER_SETTING_TYPE_UINT32_EXT = (int)(3),
        VK_LAYER_SETTING_TYPE_UINT64_EXT = (int)(4),
        VK_LAYER_SETTING_TYPE_FLOAT32_EXT = (int)(5),
        VK_LAYER_SETTING_TYPE_FLOAT64_EXT = (int)(6),
        VK_LAYER_SETTING_TYPE_STRING_EXT = (int)(7),
        VK_LAYER_SETTING_TYPE_MAX_ENUM_EXT = (int)(2147483647),
    }
}
