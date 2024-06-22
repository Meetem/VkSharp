using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public VkAccelerationStructureNV accelerationStructureNV;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureCaptureDescriptorDataInfoEXT Create()
        {
            VkAccelerationStructureCaptureDescriptorDataInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
