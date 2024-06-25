using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferInheritanceRenderingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlagsKHR flags;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkSampleCountFlags rasterizationSamples;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferInheritanceRenderingInfoKHR Create()
        {
            VkCommandBufferInheritanceRenderingInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
