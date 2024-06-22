using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkOpticalFlowGridSizeFlagBitsNV : uint
    {
        VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = (uint)(0x00000000U),
        VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = (uint)(0x00000001U),
        VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = (uint)(0x00000002U),
        VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = (uint)(0x00000004U),
        VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = (uint)(0x00000008U),
        VK_OPTICAL_FLOW_GRID_SIZE_FLAG_BITS_MAX_ENUM_NV = (uint)(0x7FFFFFFFU),
    }
}
