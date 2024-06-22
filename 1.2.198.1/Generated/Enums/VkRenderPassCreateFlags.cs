using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkRenderPassCreateFlags : uint
    {
        VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = (uint)(0x00000002U),
        VK_RENDER_PASS_CREATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
