using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 relaxedLineRasterization;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG Create()
        {
            VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
