using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageViewAddressPropertiesNVX Create()
        {
            VkImageViewAddressPropertiesNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
