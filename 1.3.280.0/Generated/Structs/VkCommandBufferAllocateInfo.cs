using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPool commandPool;
        public VkCommandBufferLevel level;
        public uint commandBufferCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferAllocateInfo Create()
        {
            VkCommandBufferAllocateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
