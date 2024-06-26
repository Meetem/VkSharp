using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkFramebuffer framebuffer;
        public VkBool32 occlusionQueryEnable;
        public VkQueryControlFlags queryFlags;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferInheritanceInfo Create()
        {
            VkCommandBufferInheritanceInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
