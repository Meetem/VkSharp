using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkEventCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkEventCreateFlags flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_EVENT_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkEventCreateInfo Create()
        {
            VkEventCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
