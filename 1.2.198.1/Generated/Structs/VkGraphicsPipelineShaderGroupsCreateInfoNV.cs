using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint pipelineCount;
        public VkPipeline* pPipelines;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGraphicsPipelineShaderGroupsCreateInfoNV Create()
        {
            VkGraphicsPipelineShaderGroupsCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
