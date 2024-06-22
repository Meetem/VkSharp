using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLatencyTimingsFrameReportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public ulong inputSampleTimeUs;
        public ulong simStartTimeUs;
        public ulong simEndTimeUs;
        public ulong renderSubmitStartTimeUs;
        public ulong renderSubmitEndTimeUs;
        public ulong presentStartTimeUs;
        public ulong presentEndTimeUs;
        public ulong driverStartTimeUs;
        public ulong driverEndTimeUs;
        public ulong osRenderQueueStartTimeUs;
        public ulong osRenderQueueEndTimeUs;
        public ulong gpuRenderStartTimeUs;
        public ulong gpuRenderEndTimeUs;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLatencyTimingsFrameReportNV Create()
        {
            VkLatencyTimingsFrameReportNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
