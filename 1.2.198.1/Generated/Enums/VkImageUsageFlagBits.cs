using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkImageUsageFlagBits : uint
    {
        VK_IMAGE_USAGE_TRANSFER_SRC_BIT = (uint)(0x00000001U),
        VK_IMAGE_USAGE_TRANSFER_DST_BIT = (uint)(0x00000002U),
        VK_IMAGE_USAGE_SAMPLED_BIT = (uint)(0x00000004U),
        VK_IMAGE_USAGE_STORAGE_BIT = (uint)(0x00000008U),
        VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = (uint)(0x00000010U),
        VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = (uint)(0x00000020U),
        VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = (uint)(0x00000040U),
        VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = (uint)(0x00000080U),
        VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = (uint)(0x00000200U),
        VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = (uint)(0x00000100U),
        VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI = (uint)(0x00040000U),
        VK_IMAGE_USAGE_SHADING_RATE_IMAGE_BIT_NV = (uint)(0x00000100U),
        VK_IMAGE_USAGE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
