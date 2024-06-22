using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint fragmentDensityOffsetCount;
        public VkOffset2D* pFragmentDensityOffsets;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassFragmentDensityMapOffsetEndInfoQCOM Create()
        {
            VkSubpassFragmentDensityMapOffsetEndInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
