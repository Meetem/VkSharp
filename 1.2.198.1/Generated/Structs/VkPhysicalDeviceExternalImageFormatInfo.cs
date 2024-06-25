using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExternalImageFormatInfo Create()
        {
            VkPhysicalDeviceExternalImageFormatInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
