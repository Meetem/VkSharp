using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingAttachmentLocationInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentLocations;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingAttachmentLocationInfoKHR Create()
        {
            VkRenderingAttachmentLocationInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
