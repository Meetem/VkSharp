using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceCreateFlags flags;
        public uint queueCreateInfoCount;
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceCreateInfo Create()
        {
            VkDeviceCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
