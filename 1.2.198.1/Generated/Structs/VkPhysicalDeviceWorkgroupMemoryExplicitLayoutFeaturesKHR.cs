using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 workgroupMemoryExplicitLayout;
        public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
        public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
        public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR Create()
        {
            VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
