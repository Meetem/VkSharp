using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSwapchainPresentScalingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagsEXT scalingBehavior;
        public VkPresentGravityFlagsEXT presentGravityX;
        public VkPresentGravityFlagsEXT presentGravityY;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSwapchainPresentScalingCreateInfoEXT Create()
        {
            VkSwapchainPresentScalingCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
