using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public uint instanceCount;
        public uint geometryCount;
        public VkGeometryNV* pGeometries;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureInfoNV Create()
        {
            VkAccelerationStructureInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
