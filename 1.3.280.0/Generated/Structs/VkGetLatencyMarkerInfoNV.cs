using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint timingCount;
        public VkLatencyTimingsFrameReportNV* pTimings;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGetLatencyMarkerInfoNV Create()
        {
            VkGetLatencyMarkerInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
