using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public VkBool32 depthClipEnable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRasterizationDepthClipStateCreateInfoEXT Create()
        {
            VkPipelineRasterizationDepthClipStateCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
