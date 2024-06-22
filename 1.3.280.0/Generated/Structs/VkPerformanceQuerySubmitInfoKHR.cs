using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint counterPassIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceQuerySubmitInfoKHR Create()
        {
            VkPerformanceQuerySubmitInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
