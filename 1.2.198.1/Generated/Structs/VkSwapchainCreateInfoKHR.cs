using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainCreateFlagsKHR flags;
        public VkSurfaceKHR surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR imageColorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlags imageUsage;
        public VkSharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkSurfaceTransformFlagsKHR preTransform;
        public VkCompositeAlphaFlagsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public VkBool32 clipped;
        public VkSwapchainKHR oldSwapchain;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSwapchainCreateInfoKHR Create()
        {
            VkSwapchainCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
