using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceMemoryOpaqueCaptureAddressInfo Create()
        {
            VkDeviceMemoryOpaqueCaptureAddressInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
