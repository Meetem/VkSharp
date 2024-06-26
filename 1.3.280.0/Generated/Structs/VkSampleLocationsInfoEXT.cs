using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSampleLocationsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationsPerPixel;
        public VkExtent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSampleLocationsInfoEXT Create()
        {
            VkSampleLocationsInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
