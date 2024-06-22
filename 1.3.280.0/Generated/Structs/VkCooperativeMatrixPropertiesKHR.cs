using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR ResultType;
        public VkBool32 saturatingAccumulation;
        public VkScopeKHR scope;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCooperativeMatrixPropertiesKHR Create()
        {
            VkCooperativeMatrixPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
