using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageType imageType;
        public VkFormat format;
        public VkExtent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public VkSampleCountFlags samples;
        public VkImageTiling tiling;
        public VkImageUsageFlags usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkImageLayout initialLayout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageCreateInfo Create()
        {
            VkImageCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
