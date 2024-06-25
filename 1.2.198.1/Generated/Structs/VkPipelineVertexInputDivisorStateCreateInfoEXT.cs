using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineVertexInputDivisorStateCreateInfoEXT Create()
        {
            VkPipelineVertexInputDivisorStateCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
