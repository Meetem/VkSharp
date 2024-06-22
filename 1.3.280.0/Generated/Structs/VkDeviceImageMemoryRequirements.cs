using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceImageMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageAspectFlags planeAspect;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceImageMemoryRequirements Create()
        {
            VkDeviceImageMemoryRequirements ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
