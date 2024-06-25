using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public uint splitInstanceBindRegionCount;
        public VkRect2D* pSplitInstanceBindRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindImageMemoryDeviceGroupInfo Create()
        {
            VkBindImageMemoryDeviceGroupInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
