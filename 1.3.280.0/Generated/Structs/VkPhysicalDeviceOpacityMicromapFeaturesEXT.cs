using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 micromap;
        public VkBool32 micromapCaptureReplay;
        public VkBool32 micromapHostCommands;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceOpacityMicromapFeaturesEXT Create()
        {
            VkPhysicalDeviceOpacityMicromapFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
