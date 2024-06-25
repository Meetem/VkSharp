using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public ulong timeout;
        public VkSemaphore semaphore;
        public VkFence fence;
        public uint deviceMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAcquireNextImageInfoKHR Create()
        {
            VkAcquireNextImageInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
