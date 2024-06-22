using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceGroupCommandBufferBeginInfo Create()
        {
            VkDeviceGroupCommandBufferBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
