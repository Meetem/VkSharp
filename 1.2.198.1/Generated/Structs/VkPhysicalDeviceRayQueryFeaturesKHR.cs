using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayQuery;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRayQueryFeaturesKHR Create()
        {
            VkPhysicalDeviceRayQueryFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
