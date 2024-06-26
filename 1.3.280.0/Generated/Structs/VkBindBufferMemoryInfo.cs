using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindBufferMemoryInfo Create()
        {
            VkBindBufferMemoryInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
