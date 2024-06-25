using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[256];
        public fixed byte version[256];
        public VkToolPurposeFlagsEXT purposes;
        public fixed byte description[256];
        public fixed byte layer[256];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceToolPropertiesEXT Create()
        {
            VkPhysicalDeviceToolPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
