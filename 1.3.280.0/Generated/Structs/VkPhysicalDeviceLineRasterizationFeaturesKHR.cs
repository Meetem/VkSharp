using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rectangularLines;
        public VkBool32 bresenhamLines;
        public VkBool32 smoothLines;
        public VkBool32 stippledRectangularLines;
        public VkBool32 stippledBresenhamLines;
        public VkBool32 stippledSmoothLines;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceLineRasterizationFeaturesKHR Create()
        {
            VkPhysicalDeviceLineRasterizationFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
