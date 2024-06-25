using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 diagnosticsConfig;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDiagnosticsConfigFeaturesNV Create()
        {
            VkPhysicalDeviceDiagnosticsConfigFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
