using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public int fd;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImportSemaphoreFdInfoKHR Create()
        {
            VkImportSemaphoreFdInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
