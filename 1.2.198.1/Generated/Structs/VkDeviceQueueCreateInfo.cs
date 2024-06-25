using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceQueueCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public float* pQueuePriorities;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceQueueCreateInfo Create()
        {
            VkDeviceQueueCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
