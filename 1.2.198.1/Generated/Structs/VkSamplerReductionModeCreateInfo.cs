using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerReductionMode reductionMode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerReductionModeCreateInfo Create()
        {
            VkSamplerReductionModeCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
