using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkAccelerationStructureGeometryDataKHR
    {
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryInstancesDataKHR instances;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureGeometryDataKHR Create()
        {
            return default;
        }
        
    }
}
