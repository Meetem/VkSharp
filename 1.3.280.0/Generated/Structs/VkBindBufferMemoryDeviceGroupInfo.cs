using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindBufferMemoryDeviceGroupInfo Create()
        {
            VkBindBufferMemoryDeviceGroupInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
