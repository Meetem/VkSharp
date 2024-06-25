using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 mutableDescriptorType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE Create()
        {
            VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
