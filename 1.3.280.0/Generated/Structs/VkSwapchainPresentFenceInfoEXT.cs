using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSwapchainPresentFenceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkFence* pFences;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSwapchainPresentFenceInfoEXT Create()
        {
            VkSwapchainPresentFenceInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
