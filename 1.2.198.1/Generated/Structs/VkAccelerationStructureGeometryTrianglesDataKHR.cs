using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public uint maxVertex;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureGeometryTrianglesDataKHR Create()
        {
            VkAccelerationStructureGeometryTrianglesDataKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
