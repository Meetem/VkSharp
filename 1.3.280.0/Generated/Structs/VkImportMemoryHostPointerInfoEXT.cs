using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public void* pHostPointer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImportMemoryHostPointerInfoEXT Create()
        {
            VkImportMemoryHostPointerInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
