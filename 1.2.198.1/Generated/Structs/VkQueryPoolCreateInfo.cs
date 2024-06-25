using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolCreateFlags flags;
        public VkQueryType queryType;
        public uint queryCount;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueryPoolCreateInfo Create()
        {
            VkQueryPoolCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
