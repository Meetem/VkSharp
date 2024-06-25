using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 timelineSemaphore;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTimelineSemaphoreFeatures Create()
        {
            VkPhysicalDeviceTimelineSemaphoreFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
