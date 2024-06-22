using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerBlockMatchWindowCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D windowExtent;
        public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerBlockMatchWindowCreateInfoQCOM Create()
        {
            VkSamplerBlockMatchWindowCreateInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
