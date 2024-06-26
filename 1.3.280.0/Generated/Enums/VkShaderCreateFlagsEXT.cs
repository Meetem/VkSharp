using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkShaderCreateFlagsEXT : uint
    {
        VK_SHADER_CREATE_LINK_STAGE_BIT_EXT = (uint)(0x00000001U),
        VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = (uint)(0x00000002U),
        VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = (uint)(0x00000004U),
        VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT = (uint)(0x00000008U),
        VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT = (uint)(0x00000010U),
        VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT = (uint)(0x00000020U),
        VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = (uint)(0x00000040U),
        VK_SHADER_CREATE_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
