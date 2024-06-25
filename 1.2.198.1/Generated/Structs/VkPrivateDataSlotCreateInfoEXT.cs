using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPrivateDataSlotCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPrivateDataSlotCreateFlagsEXT flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPrivateDataSlotCreateInfoEXT Create()
        {
            VkPrivateDataSlotCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
