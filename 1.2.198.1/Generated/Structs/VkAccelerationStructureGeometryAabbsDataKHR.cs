using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public ulong stride;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureGeometryAabbsDataKHR Create()
        {
            VkAccelerationStructureGeometryAabbsDataKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
