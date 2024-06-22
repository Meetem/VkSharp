using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkQueryResultFlags : uint
    {
        VK_QUERY_RESULT_64_BIT = (uint)(0x00000001U),
        VK_QUERY_RESULT_WAIT_BIT = (uint)(0x00000002U),
        VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = (uint)(0x00000004U),
        VK_QUERY_RESULT_PARTIAL_BIT = (uint)(0x00000008U),
        VK_QUERY_RESULT_WITH_STATUS_BIT_KHR = (uint)(0x00000010U),
        VK_QUERY_RESULT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
