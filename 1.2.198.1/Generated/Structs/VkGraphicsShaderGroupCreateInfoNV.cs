using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGraphicsShaderGroupCreateInfoNV Create()
        {
            VkGraphicsShaderGroupCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
