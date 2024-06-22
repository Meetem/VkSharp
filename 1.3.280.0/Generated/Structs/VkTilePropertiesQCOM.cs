using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkTilePropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent3D tileSize;
        public VkExtent2D apronSize;
        public VkOffset2D origin;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkTilePropertiesQCOM Create()
        {
            VkTilePropertiesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
