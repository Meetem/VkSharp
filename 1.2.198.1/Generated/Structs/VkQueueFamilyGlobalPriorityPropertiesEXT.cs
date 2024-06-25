using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint priorityCount;
        public FixedArrayVkQueueGlobalPriorityEXTSize16 priorities;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueueFamilyGlobalPriorityPropertiesEXT Create()
        {
            VkQueueFamilyGlobalPriorityPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
