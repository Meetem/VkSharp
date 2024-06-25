using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMultiDrawPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiDrawCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMultiDrawPropertiesEXT Create()
        {
            VkPhysicalDeviceMultiDrawPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
