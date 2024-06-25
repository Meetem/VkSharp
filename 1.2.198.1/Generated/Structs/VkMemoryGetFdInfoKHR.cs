using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryGetFdInfoKHR Create()
        {
            VkMemoryGetFdInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
