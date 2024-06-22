using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkQueryType
    {
        VK_QUERY_TYPE_OCCLUSION = (int)(0),
        VK_QUERY_TYPE_PIPELINE_STATISTICS = (int)(1),
        VK_QUERY_TYPE_TIMESTAMP = (int)(2),
        VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = (int)(1000028004),
        VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = (int)(1000116000),
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = (int)(1000150000),
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = (int)(1000150001),
        VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = (int)(1000165000),
        VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = (int)(1000210000),
        VK_QUERY_TYPE_MAX_ENUM = (int)(2147483647),
    }
}
