using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindImageMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindImageMemoryInfo Create()
        {
            VkBindImageMemoryInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
