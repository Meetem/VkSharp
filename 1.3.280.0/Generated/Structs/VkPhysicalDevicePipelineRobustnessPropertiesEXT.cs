using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePipelineRobustnessPropertiesEXT Create()
        {
            VkPhysicalDevicePipelineRobustnessPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
