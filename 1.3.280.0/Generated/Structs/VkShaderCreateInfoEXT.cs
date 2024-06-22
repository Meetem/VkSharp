using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkShaderCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCreateFlagsEXT flags;
        public VkShaderStageFlags stage;
        public VkShaderStageFlags nextStage;
        public VkShaderCodeTypeEXT codeType;
        public ulong codeSize;
        public void* pCode;
        public byte* pName;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public VkSpecializationInfo* pSpecializationInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkShaderCreateInfoEXT Create()
        {
            VkShaderCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
