using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassEndInfo
    {
        public VkStructureType sType;
        public void* pNext;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_END_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassEndInfo Create()
        {
            VkSubpassEndInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
