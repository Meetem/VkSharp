using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindImageMemorySwapchainInfoKHR Create()
        {
            VkBindImageMemorySwapchainInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
