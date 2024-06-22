using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageProcessingFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureSampleWeighted;
        public VkBool32 textureBoxFilter;
        public VkBool32 textureBlockMatch;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageProcessingFeaturesQCOM Create()
        {
            VkPhysicalDeviceImageProcessingFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
