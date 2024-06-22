using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong marker;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceMarkerInfoINTEL Create()
        {
            VkPerformanceMarkerInfoINTEL ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
