using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterDescriptionFlagsKHR flags;
        public fixed byte name[256];
        public fixed byte category[256];
        public fixed byte description[256];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceCounterDescriptionKHR Create()
        {
            VkPerformanceCounterDescriptionKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
