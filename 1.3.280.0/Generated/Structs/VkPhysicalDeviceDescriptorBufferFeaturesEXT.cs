using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorBuffer;
        public VkBool32 descriptorBufferCaptureReplay;
        public VkBool32 descriptorBufferImageLayoutIgnored;
        public VkBool32 descriptorBufferPushDescriptors;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDescriptorBufferFeaturesEXT Create()
        {
            VkPhysicalDeviceDescriptorBufferFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
