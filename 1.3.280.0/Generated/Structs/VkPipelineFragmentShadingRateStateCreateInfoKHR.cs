using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentSize;
        public FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineFragmentShadingRateStateCreateInfoKHR Create()
        {
            VkPipelineFragmentShadingRateStateCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
