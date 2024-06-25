using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceLineRasterizationPropertiesEXT Create()
        {
            VkPhysicalDeviceLineRasterizationPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
