using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        public fixed byte driverName[256];
        public fixed byte driverInfo[256];
        public VkConformanceVersion conformanceVersion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDriverProperties Create()
        {
            VkPhysicalDeviceDriverProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
