using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBufferUsageFlags flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferBeginInfo Create()
        {
            VkCommandBufferBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
