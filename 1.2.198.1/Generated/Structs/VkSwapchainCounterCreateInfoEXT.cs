using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCounterFlagsEXT surfaceCounters;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSwapchainCounterCreateInfoEXT Create()
        {
            VkSwapchainCounterCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
