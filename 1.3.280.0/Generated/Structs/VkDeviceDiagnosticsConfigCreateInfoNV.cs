using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceDiagnosticsConfigFlagsNV flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceDiagnosticsConfigCreateInfoNV Create()
        {
            VkDeviceDiagnosticsConfigCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
