using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePrivateDataFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 privateData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePrivateDataFeatures Create()
        {
            VkPhysicalDevicePrivateDataFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
