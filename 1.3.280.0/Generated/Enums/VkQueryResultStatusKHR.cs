using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkQueryResultStatusKHR
    {
        VK_QUERY_RESULT_STATUS_ERROR_KHR = (int)(-1),
        VK_QUERY_RESULT_STATUS_NOT_READY_KHR = (int)(0),
        VK_QUERY_RESULT_STATUS_COMPLETE_KHR = (int)(1),
        VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR = (int)(-1000299000),
        VK_QUERY_RESULT_STATUS_MAX_ENUM_KHR = (int)(2147483647),
    }
}
