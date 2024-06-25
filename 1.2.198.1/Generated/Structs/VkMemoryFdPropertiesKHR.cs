using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryFdPropertiesKHR Create()
        {
            VkMemoryFdPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
