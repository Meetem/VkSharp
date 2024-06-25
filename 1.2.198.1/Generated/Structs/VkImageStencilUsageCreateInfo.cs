using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags stencilUsage;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageStencilUsageCreateInfo Create()
        {
            VkImageStencilUsageCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
