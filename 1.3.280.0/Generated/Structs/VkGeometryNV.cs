using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGeometryNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkGeometryDataNV geometry;
        public VkGeometryFlagsKHR flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GEOMETRY_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGeometryNV Create()
        {
            VkGeometryNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
