using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCapabilityFlagsKHR flags;
        public ulong minBitstreamBufferOffsetAlignment;
        public ulong minBitstreamBufferSizeAlignment;
        public VkExtent2D pictureAccessGranularity;
        public VkExtent2D minCodedExtent;
        public VkExtent2D maxCodedExtent;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties stdHeaderVersion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoCapabilitiesKHR Create()
        {
            VkVideoCapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
