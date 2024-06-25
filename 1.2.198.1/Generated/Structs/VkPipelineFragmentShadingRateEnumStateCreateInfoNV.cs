using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFragmentShadingRateTypeNV shadingRateType;
        public VkFragmentShadingRateNV shadingRate;
        public FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineFragmentShadingRateEnumStateCreateInfoNV Create()
        {
            VkPipelineFragmentShadingRateEnumStateCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
