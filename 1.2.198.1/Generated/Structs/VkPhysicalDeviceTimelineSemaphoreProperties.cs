using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxTimelineSemaphoreValueDifference;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTimelineSemaphoreProperties Create()
        {
            VkPhysicalDeviceTimelineSemaphoreProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
