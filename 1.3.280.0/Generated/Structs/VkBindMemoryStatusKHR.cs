using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindMemoryStatusKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResult* pResult;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindMemoryStatusKHR Create()
        {
            VkBindMemoryStatusKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
