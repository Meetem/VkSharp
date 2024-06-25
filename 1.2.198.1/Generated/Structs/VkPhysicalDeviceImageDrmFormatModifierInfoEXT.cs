using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT Create()
        {
            VkPhysicalDeviceImageDrmFormatModifierInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
