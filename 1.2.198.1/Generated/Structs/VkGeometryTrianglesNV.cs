using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public VkFormat vertexFormat;
        public VkBuffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public VkIndexType indexType;
        public VkBuffer transformData;
        public ulong transformOffset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGeometryTrianglesNV Create()
        {
            VkGeometryTrianglesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
