using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDebugReportFlagsEXT : uint
    {
        VK_DEBUG_REPORT_INFORMATION_BIT_EXT = (uint)(0x00000001U),
        VK_DEBUG_REPORT_WARNING_BIT_EXT = (uint)(0x00000002U),
        VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = (uint)(0x00000004U),
        VK_DEBUG_REPORT_ERROR_BIT_EXT = (uint)(0x00000008U),
        VK_DEBUG_REPORT_DEBUG_BIT_EXT = (uint)(0x00000010U),
        VK_DEBUG_REPORT_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
