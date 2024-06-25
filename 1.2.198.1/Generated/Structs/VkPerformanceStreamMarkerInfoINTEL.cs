using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public uint marker;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceStreamMarkerInfoINTEL Create()
        {
            VkPerformanceStreamMarkerInfoINTEL ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
