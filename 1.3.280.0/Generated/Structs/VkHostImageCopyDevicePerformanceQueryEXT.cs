using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkHostImageCopyDevicePerformanceQueryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 optimalDeviceAccess;
        public VkBool32 identicalMemoryLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkHostImageCopyDevicePerformanceQueryEXT Create()
        {
            VkHostImageCopyDevicePerformanceQueryEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
