using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineVertexInputStateCreateFlags flags;
        public uint vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription* pVertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineVertexInputStateCreateInfo Create()
        {
            VkPipelineVertexInputStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
