using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderZeroInitializeWorkgroupMemory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures Create()
        {
            VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
