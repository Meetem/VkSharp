using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueGlobalPriorityEXT globalPriority;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceQueueGlobalPriorityCreateInfoEXT Create()
        {
            VkDeviceQueueGlobalPriorityCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
