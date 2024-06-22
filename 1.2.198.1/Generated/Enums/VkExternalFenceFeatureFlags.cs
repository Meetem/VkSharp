using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkExternalFenceFeatureFlags : uint
    {
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = (uint)(0x00000001U),
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = (uint)(0x00000002U),
        VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT_KHR = (uint)(0x00000001U),
        VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT_KHR = (uint)(0x00000002U),
        VK_EXTERNAL_FENCE_FEATURE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
