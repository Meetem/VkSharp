using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perStageDescriptorSet;
        public VkBool32 dynamicPipelineLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePerStageDescriptorSetFeaturesNV Create()
        {
            VkPhysicalDevicePerStageDescriptorSetFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
