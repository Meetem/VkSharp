using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMicromapBuildSizesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong micromapSize;
        public ulong buildScratchSize;
        public VkBool32 discardable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMicromapBuildSizesInfoEXT Create()
        {
            VkMicromapBuildSizesInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
