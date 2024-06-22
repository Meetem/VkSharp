using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSubpassDescriptionFlagBits : uint
    {
        VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = (uint)(0x00000001U),
        VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = (uint)(0x00000002U),
        VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM = (uint)(0x00000004U),
        VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM = (uint)(0x00000008U),
        VK_SUBPASS_DESCRIPTION_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
