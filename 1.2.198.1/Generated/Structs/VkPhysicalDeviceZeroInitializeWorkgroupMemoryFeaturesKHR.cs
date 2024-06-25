using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderZeroInitializeWorkgroupMemory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR Create()
        {
            VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
