using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryGetRemoteAddressInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryGetRemoteAddressInfoNV Create()
        {
            VkMemoryGetRemoteAddressInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
