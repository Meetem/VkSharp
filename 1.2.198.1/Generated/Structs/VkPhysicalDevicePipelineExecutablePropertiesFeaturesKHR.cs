using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineExecutableInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR Create()
        {
            VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
