using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV accelerationStructure;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureMemoryRequirementsInfoNV Create()
        {
            VkAccelerationStructureMemoryRequirementsInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
