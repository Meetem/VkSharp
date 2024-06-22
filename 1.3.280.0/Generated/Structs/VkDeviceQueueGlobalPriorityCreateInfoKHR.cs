using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueGlobalPriorityKHR globalPriority;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceQueueGlobalPriorityCreateInfoKHR Create()
        {
            VkDeviceQueueGlobalPriorityCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
