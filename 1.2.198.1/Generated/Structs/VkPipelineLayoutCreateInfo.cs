using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayoutCreateFlags flags;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineLayoutCreateInfo Create()
        {
            VkPipelineLayoutCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
