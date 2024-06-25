using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
        public uint maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRayTracingPipelineCreateInfoKHR Create()
        {
            VkRayTracingPipelineCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
