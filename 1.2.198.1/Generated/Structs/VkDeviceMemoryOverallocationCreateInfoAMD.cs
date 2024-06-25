using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceMemoryOverallocationCreateInfoAMD Create()
        {
            VkDeviceMemoryOverallocationCreateInfoAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
