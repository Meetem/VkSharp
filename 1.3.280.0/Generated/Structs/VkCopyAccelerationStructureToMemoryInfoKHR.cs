using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyAccelerationStructureToMemoryInfoKHR Create()
        {
            VkCopyAccelerationStructureToMemoryInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
