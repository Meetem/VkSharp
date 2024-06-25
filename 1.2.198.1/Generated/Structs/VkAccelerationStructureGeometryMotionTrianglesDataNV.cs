using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR vertexData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureGeometryMotionTrianglesDataNV Create()
        {
            VkAccelerationStructureGeometryMotionTrianglesDataNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
