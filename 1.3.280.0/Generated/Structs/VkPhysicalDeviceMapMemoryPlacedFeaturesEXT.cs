using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryMapPlaced;
        public VkBool32 memoryMapRangePlaced;
        public VkBool32 memoryUnmapReserve;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMapMemoryPlacedFeaturesEXT Create()
        {
            VkPhysicalDeviceMapMemoryPlacedFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
