using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewType imageViewType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageViewImageFormatInfoEXT Create()
        {
            VkPhysicalDeviceImageViewImageFormatInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
