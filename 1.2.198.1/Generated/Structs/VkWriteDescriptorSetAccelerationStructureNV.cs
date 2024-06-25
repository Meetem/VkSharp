using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkWriteDescriptorSetAccelerationStructureNV Create()
        {
            VkWriteDescriptorSetAccelerationStructureNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
