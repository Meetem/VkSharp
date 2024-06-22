using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindVideoSessionMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public ulong memorySize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindVideoSessionMemoryInfoKHR Create()
        {
            VkBindVideoSessionMemoryInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
