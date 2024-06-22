using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueryLowLatencySupportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pQueriedLowLatencyData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueryLowLatencySupportNV Create()
        {
            VkQueryLowLatencySupportNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
