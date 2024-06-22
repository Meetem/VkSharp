using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLatencySubmissionPresentIdNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLatencySubmissionPresentIdNV Create()
        {
            VkLatencySubmissionPresentIdNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
