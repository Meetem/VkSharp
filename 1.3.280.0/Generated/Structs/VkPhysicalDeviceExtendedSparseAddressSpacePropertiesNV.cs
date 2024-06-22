using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong extendedSparseAddressSpaceSize;
        public VkImageUsageFlags extendedSparseImageUsageFlags;
        public VkBufferUsageFlags extendedSparseBufferUsageFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV Create()
        {
            VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
