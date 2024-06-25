using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPushDescriptors;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePushDescriptorPropertiesKHR Create()
        {
            VkPhysicalDevicePushDescriptorPropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
