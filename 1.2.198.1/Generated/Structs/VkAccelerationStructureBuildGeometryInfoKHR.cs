using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public VkBuildAccelerationStructureModeKHR mode;
        public VkAccelerationStructureKHR srcAccelerationStructure;
        public VkAccelerationStructureKHR dstAccelerationStructure;
        public uint geometryCount;
        public VkAccelerationStructureGeometryKHR* pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR scratchData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureBuildGeometryInfoKHR Create()
        {
            VkAccelerationStructureBuildGeometryInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
