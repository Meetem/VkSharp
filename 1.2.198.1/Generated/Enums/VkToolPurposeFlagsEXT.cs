using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkToolPurposeFlagsEXT : uint
    {
        VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = (uint)(0x00000001U),
        VK_TOOL_PURPOSE_PROFILING_BIT_EXT = (uint)(0x00000002U),
        VK_TOOL_PURPOSE_TRACING_BIT_EXT = (uint)(0x00000004U),
        VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = (uint)(0x00000008U),
        VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = (uint)(0x00000010U),
        VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = (uint)(0x00000020U),
        VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = (uint)(0x00000040U),
        VK_TOOL_PURPOSE_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
