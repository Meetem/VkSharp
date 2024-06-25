using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubmitInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubmitFlagsKHR flags;
        public uint waitSemaphoreInfoCount;
        public VkSemaphoreSubmitInfoKHR* pWaitSemaphoreInfos;
        public uint commandBufferInfoCount;
        public VkCommandBufferSubmitInfoKHR* pCommandBufferInfos;
        public uint signalSemaphoreInfoCount;
        public VkSemaphoreSubmitInfoKHR* pSignalSemaphoreInfos;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubmitInfo2KHR Create()
        {
            return default;
        }
        
    }
}
