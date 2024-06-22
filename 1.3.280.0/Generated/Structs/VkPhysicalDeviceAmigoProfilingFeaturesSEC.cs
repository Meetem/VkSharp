using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 amigoProfiling;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceAmigoProfilingFeaturesSEC Create()
        {
            VkPhysicalDeviceAmigoProfilingFeaturesSEC ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
