using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureMotionInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInstances;
        public VkAccelerationStructureMotionInfoFlagsNV flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureMotionInfoNV Create()
        {
            VkAccelerationStructureMotionInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
