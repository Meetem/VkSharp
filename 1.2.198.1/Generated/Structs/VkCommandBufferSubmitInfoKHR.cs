using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBuffer commandBuffer;
        public uint deviceMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferSubmitInfoKHR Create()
        {
            VkCommandBufferSubmitInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
