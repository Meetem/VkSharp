using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRobustnessCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT images;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRobustnessCreateInfoEXT Create()
        {
            VkPipelineRobustnessCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
