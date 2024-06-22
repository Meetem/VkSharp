using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferDeviceAddressInfo Create()
        {
            VkBufferDeviceAddressInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
