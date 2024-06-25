using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlags flags;
        public VkBufferUsageFlags usage;
        public VkExternalMemoryHandleTypeFlags handleType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExternalBufferInfo Create()
        {
            VkPhysicalDeviceExternalBufferInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
