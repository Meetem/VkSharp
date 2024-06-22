using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkCullModeFlags : uint
    {
        VK_CULL_MODE_NONE = (uint)(0x00000000U),
        VK_CULL_MODE_FRONT_BIT = (uint)(0x00000001U),
        VK_CULL_MODE_BACK_BIT = (uint)(0x00000002U),
        VK_CULL_MODE_FRONT_AND_BACK = (uint)(0x00000003U),
        VK_CULL_MODE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
