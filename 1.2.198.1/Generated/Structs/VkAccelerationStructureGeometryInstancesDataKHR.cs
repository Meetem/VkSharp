using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 arrayOfPointers;
        public VkDeviceOrHostAddressConstKHR data;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureGeometryInstancesDataKHR Create()
        {
            VkAccelerationStructureGeometryInstancesDataKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
