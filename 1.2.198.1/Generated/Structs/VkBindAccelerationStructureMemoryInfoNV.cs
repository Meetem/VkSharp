using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindAccelerationStructureMemoryInfoNV Create()
        {
            VkBindAccelerationStructureMemoryInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
