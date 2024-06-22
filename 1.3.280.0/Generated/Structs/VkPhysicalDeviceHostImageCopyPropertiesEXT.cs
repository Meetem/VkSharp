using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceHostImageCopyPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint copySrcLayoutCount;
        public VkImageLayout* pCopySrcLayouts;
        public uint copyDstLayoutCount;
        public VkImageLayout* pCopyDstLayouts;
        public fixed byte optimalTilingLayoutUUID[16];
        public VkBool32 identicalMemoryTypeRequirements;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceHostImageCopyPropertiesEXT Create()
        {
            VkPhysicalDeviceHostImageCopyPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
