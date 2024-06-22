using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBlitImageCubicWeightsInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBlitImageCubicWeightsInfoQCOM Create()
        {
            VkBlitImageCubicWeightsInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
