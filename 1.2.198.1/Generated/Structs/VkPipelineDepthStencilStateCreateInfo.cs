using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDepthStencilStateCreateFlags flags;
        public VkBool32 depthTestEnable;
        public VkBool32 depthWriteEnable;
        public VkCompareOp depthCompareOp;
        public VkBool32 depthBoundsTestEnable;
        public VkBool32 stencilTestEnable;
        public VkStencilOpState front;
        public VkStencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineDepthStencilStateCreateInfo Create()
        {
            VkPipelineDepthStencilStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
