using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryOpaqueCaptureAddressAllocateInfo Create()
        {
            VkMemoryOpaqueCaptureAddressAllocateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
