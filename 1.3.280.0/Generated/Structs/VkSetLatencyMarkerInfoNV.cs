using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public VkLatencyMarkerNV marker;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSetLatencyMarkerInfoNV Create()
        {
            VkSetLatencyMarkerInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
