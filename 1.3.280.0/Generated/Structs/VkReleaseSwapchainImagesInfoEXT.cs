using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkReleaseSwapchainImagesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndexCount;
        public uint* pImageIndices;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkReleaseSwapchainImagesInfoEXT Create()
        {
            VkReleaseSwapchainImagesInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
