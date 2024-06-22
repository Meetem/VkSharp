using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV : uint
    {
        VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = (uint)(0x00000001U),
        VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = (uint)(0x00000002U),
        VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = (uint)(0x00000004U),
        VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
