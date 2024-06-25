using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSamplerFilterMinmaxProperties Create()
        {
            VkPhysicalDeviceSamplerFilterMinmaxProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
