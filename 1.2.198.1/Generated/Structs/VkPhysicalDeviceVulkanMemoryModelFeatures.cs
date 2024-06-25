using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vulkanMemoryModel;
        public VkBool32 vulkanMemoryModelDeviceScope;
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVulkanMemoryModelFeatures Create()
        {
            VkPhysicalDeviceVulkanMemoryModelFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
