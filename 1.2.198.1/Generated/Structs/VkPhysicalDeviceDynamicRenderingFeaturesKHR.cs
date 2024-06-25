using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dynamicRendering;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDynamicRenderingFeaturesKHR Create()
        {
            VkPhysicalDeviceDynamicRenderingFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
