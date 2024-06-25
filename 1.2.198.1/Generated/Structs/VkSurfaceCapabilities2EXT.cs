using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
        public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfaceCapabilities2EXT Create()
        {
            VkSurfaceCapabilities2EXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
