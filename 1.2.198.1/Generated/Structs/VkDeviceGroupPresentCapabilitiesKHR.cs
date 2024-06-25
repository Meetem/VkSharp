using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint presentMask[32];
        public VkDeviceGroupPresentModeFlagsKHR modes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceGroupPresentCapabilitiesKHR Create()
        {
            VkDeviceGroupPresentCapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
