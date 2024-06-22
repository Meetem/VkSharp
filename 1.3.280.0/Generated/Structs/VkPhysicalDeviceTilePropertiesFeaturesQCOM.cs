using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 tileProperties;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTilePropertiesFeaturesQCOM Create()
        {
            VkPhysicalDeviceTilePropertiesFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
