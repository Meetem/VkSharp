using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong compactedSize;
        public VkAccelerationStructureInfoNV info;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureCreateInfoNV Create()
        {
            VkAccelerationStructureCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
