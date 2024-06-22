using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueueFamilyQueryResultStatusPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 queryResultStatusSupport;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueueFamilyQueryResultStatusPropertiesKHR Create()
        {
            VkQueueFamilyQueryResultStatusPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
