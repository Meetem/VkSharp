using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRasterizationStateRasterizationOrderAMD Create()
        {
            VkPipelineRasterizationStateRasterizationOrderAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
