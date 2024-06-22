using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPresentIdKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public ulong* pPresentIds;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_ID_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPresentIdKHR Create()
        {
            VkPresentIdKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
