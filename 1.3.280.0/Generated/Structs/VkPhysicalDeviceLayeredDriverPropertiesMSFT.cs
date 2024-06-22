using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLayeredDriverUnderlyingApiMSFT underlyingAPI;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceLayeredDriverPropertiesMSFT Create()
        {
            VkPhysicalDeviceLayeredDriverPropertiesMSFT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
