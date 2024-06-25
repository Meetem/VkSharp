using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImportFenceFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public int fd;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImportFenceFdInfoKHR Create()
        {
            VkImportFenceFdInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
