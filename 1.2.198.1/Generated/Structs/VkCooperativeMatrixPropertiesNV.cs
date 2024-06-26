using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeNV AType;
        public VkComponentTypeNV BType;
        public VkComponentTypeNV CType;
        public VkComponentTypeNV DType;
        public VkScopeNV scope;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCooperativeMatrixPropertiesNV Create()
        {
            VkCooperativeMatrixPropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
