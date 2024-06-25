using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRenderingCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRenderingCreateInfoKHR Create()
        {
            VkPipelineRenderingCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
