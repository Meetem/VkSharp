using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSubgroupFeatureFlagBits : uint
    {
        VK_SUBGROUP_FEATURE_BASIC_BIT = (uint)(0x00000001U),
        VK_SUBGROUP_FEATURE_VOTE_BIT = (uint)(0x00000002U),
        VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = (uint)(0x00000004U),
        VK_SUBGROUP_FEATURE_BALLOT_BIT = (uint)(0x00000008U),
        VK_SUBGROUP_FEATURE_SHUFFLE_BIT = (uint)(0x00000010U),
        VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = (uint)(0x00000020U),
        VK_SUBGROUP_FEATURE_CLUSTERED_BIT = (uint)(0x00000040U),
        VK_SUBGROUP_FEATURE_QUAD_BIT = (uint)(0x00000080U),
        VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = (uint)(0x00000100U),
        VK_SUBGROUP_FEATURE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
