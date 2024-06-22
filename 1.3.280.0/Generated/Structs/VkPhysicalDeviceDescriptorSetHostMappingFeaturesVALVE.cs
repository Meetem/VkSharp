using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorSetHostMapping;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE Create()
        {
            VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
