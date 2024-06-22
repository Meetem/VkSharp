using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLatencySleepInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore signalSemaphore;
        public ulong value;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLatencySleepInfoNV Create()
        {
            VkLatencySleepInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
