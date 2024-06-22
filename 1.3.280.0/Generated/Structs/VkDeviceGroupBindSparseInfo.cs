using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceGroupBindSparseInfo Create()
        {
            VkDeviceGroupBindSparseInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
