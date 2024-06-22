using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkLatencyMarkerNV
    {
        VK_LATENCY_MARKER_SIMULATION_START_NV = (int)(0),
        VK_LATENCY_MARKER_SIMULATION_END_NV = (int)(1),
        VK_LATENCY_MARKER_RENDERSUBMIT_START_NV = (int)(2),
        VK_LATENCY_MARKER_RENDERSUBMIT_END_NV = (int)(3),
        VK_LATENCY_MARKER_PRESENT_START_NV = (int)(4),
        VK_LATENCY_MARKER_PRESENT_END_NV = (int)(5),
        VK_LATENCY_MARKER_INPUT_SAMPLE_NV = (int)(6),
        VK_LATENCY_MARKER_TRIGGER_FLASH_NV = (int)(7),
        VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV = (int)(8),
        VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV = (int)(9),
        VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV = (int)(10),
        VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV = (int)(11),
        VK_LATENCY_MARKER_MAX_ENUM_NV = (int)(2147483647),
    }
}
