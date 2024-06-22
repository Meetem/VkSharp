using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint requiredSubgroupSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineShaderStageRequiredSubgroupSizeCreateInfo Create()
        {
            VkPipelineShaderStageRequiredSubgroupSizeCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
