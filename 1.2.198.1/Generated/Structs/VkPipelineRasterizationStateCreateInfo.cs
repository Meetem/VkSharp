using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationStateCreateFlags flags;
        public VkBool32 depthClampEnable;
        public VkBool32 rasterizerDiscardEnable;
        public VkPolygonMode polygonMode;
        public VkCullModeFlags cullMode;
        public VkFrontFace frontFace;
        public VkBool32 depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRasterizationStateCreateInfo Create()
        {
            VkPipelineRasterizationStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
