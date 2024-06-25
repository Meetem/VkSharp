using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueryPoolPerformanceQueryCreateInfoINTEL Create()
        {
            VkQueryPoolPerformanceQueryCreateInfoINTEL ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
