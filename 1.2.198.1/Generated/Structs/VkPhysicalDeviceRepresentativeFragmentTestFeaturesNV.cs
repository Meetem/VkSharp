using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTest;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV Create()
        {
            VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
