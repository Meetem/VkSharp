using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceCoherentMemory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceCoherentMemoryFeaturesAMD Create()
        {
            VkPhysicalDeviceCoherentMemoryFeaturesAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
