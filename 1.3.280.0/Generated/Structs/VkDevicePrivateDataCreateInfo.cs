using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDevicePrivateDataCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint privateDataSlotRequestCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDevicePrivateDataCreateInfo Create()
        {
            VkDevicePrivateDataCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
