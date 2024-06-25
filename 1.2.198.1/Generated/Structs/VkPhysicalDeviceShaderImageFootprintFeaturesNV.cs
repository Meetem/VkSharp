using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageFootprint;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderImageFootprintFeaturesNV Create()
        {
            VkPhysicalDeviceShaderImageFootprintFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
