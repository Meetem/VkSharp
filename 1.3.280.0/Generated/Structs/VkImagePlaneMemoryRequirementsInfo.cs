using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImagePlaneMemoryRequirementsInfo Create()
        {
            VkImagePlaneMemoryRequirementsInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
