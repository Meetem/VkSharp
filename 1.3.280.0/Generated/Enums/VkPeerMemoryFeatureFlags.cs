using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkPeerMemoryFeatureFlags : uint
    {
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = (uint)(0x00000001U),
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = (uint)(0x00000002U),
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = (uint)(0x00000004U),
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = (uint)(0x00000008U),
        VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT_KHR = (uint)(0x00000001U),
        VK_PEER_MEMORY_FEATURE_COPY_DST_BIT_KHR = (uint)(0x00000002U),
        VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT_KHR = (uint)(0x00000004U),
        VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT_KHR = (uint)(0x00000008U),
        VK_PEER_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
