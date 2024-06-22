using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeCapabilityFlagsKHR flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeCapabilitiesKHR Create()
        {
            VkVideoDecodeCapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
