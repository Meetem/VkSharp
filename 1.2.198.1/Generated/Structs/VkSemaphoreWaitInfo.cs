using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSemaphoreWaitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreWaitFlags flags;
        public uint semaphoreCount;
        public VkSemaphore* pSemaphores;
        public ulong* pValues;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSemaphoreWaitInfo Create()
        {
            VkSemaphoreWaitInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
