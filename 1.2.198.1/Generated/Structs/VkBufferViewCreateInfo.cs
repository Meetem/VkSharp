using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferViewCreateFlags flags;
        public VkBuffer buffer;
        public VkFormat format;
        public ulong offset;
        public ulong range;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferViewCreateInfo Create()
        {
            VkBufferViewCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
