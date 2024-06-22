using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkOpticalFlowSessionCreateFlagsNV : uint
    {
        VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV = (uint)(0x00000001U),
        VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV = (uint)(0x00000002U),
        VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV = (uint)(0x00000004U),
        VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV = (uint)(0x00000008U),
        VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV = (uint)(0x00000010U),
        VK_OPTICAL_FLOW_SESSION_CREATE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
