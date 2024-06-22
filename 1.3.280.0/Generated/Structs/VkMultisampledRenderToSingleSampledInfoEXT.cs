using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMultisampledRenderToSingleSampledInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multisampledRenderToSingleSampledEnable;
        public VkSampleCountFlags rasterizationSamples;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMultisampledRenderToSingleSampledInfoEXT Create()
        {
            VkMultisampledRenderToSingleSampledInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
