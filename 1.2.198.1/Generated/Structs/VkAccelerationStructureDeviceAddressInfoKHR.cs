using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureDeviceAddressInfoKHR Create()
        {
            VkAccelerationStructureDeviceAddressInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
