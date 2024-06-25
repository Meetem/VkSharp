using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineShaderStageCreateFlags flags;
        public VkShaderStageFlags stage;
        public VkShaderModule module;
        public byte* pName;
        public VkSpecializationInfo* pSpecializationInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineShaderStageCreateInfo Create()
        {
            VkPipelineShaderStageCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
