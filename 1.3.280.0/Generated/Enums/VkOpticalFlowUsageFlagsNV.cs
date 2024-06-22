using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkOpticalFlowUsageFlagsNV : uint
    {
        VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV = (uint)(0x00000000U),
        VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV = (uint)(0x00000001U),
        VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV = (uint)(0x00000002U),
        VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV = (uint)(0x00000004U),
        VK_OPTICAL_FLOW_USAGE_COST_BIT_NV = (uint)(0x00000008U),
        VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV = (uint)(0x00000010U),
        VK_OPTICAL_FLOW_USAGE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
