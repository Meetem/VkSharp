using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hostQueryReset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceHostQueryResetFeatures Create()
        {
            VkPhysicalDeviceHostQueryResetFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
