using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subpassShading;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSubpassShadingFeaturesHUAWEI Create()
        {
            VkPhysicalDeviceSubpassShadingFeaturesHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
