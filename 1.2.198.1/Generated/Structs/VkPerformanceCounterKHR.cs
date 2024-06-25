using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPerformanceCounterKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterUnitKHR unit;
        public VkPerformanceCounterScopeKHR scope;
        public VkPerformanceCounterStorageKHR storage;
        public fixed byte uuid[16];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceCounterKHR Create()
        {
            VkPerformanceCounterKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
