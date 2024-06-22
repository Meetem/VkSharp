using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSemaphoreGetFdInfoKHR Create()
        {
            VkSemaphoreGetFdInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
