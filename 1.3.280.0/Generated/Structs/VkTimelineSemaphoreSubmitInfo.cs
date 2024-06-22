using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValueCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public ulong* pSignalSemaphoreValues;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkTimelineSemaphoreSubmitInfo Create()
        {
            VkTimelineSemaphoreSubmitInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
