using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkValidationFeatureEnableEXT
    {
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = (int)(0),
        VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = (int)(1),
        VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = (int)(2),
        VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = (int)(3),
        VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = (int)(4),
        VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT = (int)(2147483647),
    }
}
