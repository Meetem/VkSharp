using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassContents contents;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassBeginInfo Create()
        {
            VkSubpassBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
