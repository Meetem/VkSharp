using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkPipelineLayoutCreateFlagBits : uint
    {
        VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = (uint)(0x00000002U),
        VK_PIPELINE_LAYOUT_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
