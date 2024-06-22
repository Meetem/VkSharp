using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageRobustnessFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustImageAccess;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageRobustnessFeatures Create()
        {
            VkPhysicalDeviceImageRobustnessFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
