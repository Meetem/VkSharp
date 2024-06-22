using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPrivateDataSlotCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPrivateDataSlotCreateFlags flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPrivateDataSlotCreateInfo Create()
        {
            VkPrivateDataSlotCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
