using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineViewportStateCreateFlags flags;
        public uint viewportCount;
        public VkViewport* pViewports;
        public uint scissorCount;
        public VkRect2D* pScissors;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineViewportStateCreateInfo Create()
        {
            VkPipelineViewportStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
