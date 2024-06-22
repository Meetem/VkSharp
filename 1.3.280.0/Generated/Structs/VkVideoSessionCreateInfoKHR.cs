using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoSessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public VkVideoSessionCreateFlagsKHR flags;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public VkFormat pictureFormat;
        public VkExtent2D maxCodedExtent;
        public VkFormat referencePictureFormat;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties* pStdHeaderVersion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoSessionCreateInfoKHR Create()
        {
            VkVideoSessionCreateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
