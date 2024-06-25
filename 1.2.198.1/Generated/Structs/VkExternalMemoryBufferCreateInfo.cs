using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkExternalMemoryBufferCreateInfo Create()
        {
            VkExternalMemoryBufferCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
