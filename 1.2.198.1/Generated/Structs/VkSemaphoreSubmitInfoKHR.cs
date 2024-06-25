using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSemaphoreSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public VkPipelineStageFlags2KHR stageMask;
        public uint deviceIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSemaphoreSubmitInfoKHR Create()
        {
            VkSemaphoreSubmitInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
