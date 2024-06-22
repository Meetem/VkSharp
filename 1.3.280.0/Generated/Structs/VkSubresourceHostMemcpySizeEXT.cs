using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubresourceHostMemcpySizeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubresourceHostMemcpySizeEXT Create()
        {
            VkSubresourceHostMemcpySizeEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
