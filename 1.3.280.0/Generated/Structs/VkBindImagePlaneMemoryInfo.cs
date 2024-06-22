using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindImagePlaneMemoryInfo Create()
        {
            VkBindImagePlaneMemoryInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
