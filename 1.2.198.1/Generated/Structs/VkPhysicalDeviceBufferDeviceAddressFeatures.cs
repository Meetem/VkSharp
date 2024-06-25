using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceBufferDeviceAddressFeatures Create()
        {
            VkPhysicalDeviceBufferDeviceAddressFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
