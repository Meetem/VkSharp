using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureVersionInfoKHR Create()
        {
            VkAccelerationStructureVersionInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
