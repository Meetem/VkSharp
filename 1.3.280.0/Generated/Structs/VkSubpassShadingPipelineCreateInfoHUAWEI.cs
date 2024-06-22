using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassShadingPipelineCreateInfoHUAWEI Create()
        {
            VkSubpassShadingPipelineCreateInfoHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
