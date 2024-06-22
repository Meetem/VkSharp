using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkOpticalFlowExecuteFlagBitsNV : uint
    {
        VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV = (uint)(0x00000001U),
        VK_OPTICAL_FLOW_EXECUTE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
