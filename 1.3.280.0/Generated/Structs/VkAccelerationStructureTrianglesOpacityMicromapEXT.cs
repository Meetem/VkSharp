using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureTrianglesOpacityMicromapEXT Create()
        {
            VkAccelerationStructureTrianglesOpacityMicromapEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
