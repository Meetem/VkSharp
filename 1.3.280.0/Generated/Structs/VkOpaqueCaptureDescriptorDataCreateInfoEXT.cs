using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* opaqueCaptureDescriptorData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkOpaqueCaptureDescriptorDataCreateInfoEXT Create()
        {
            VkOpaqueCaptureDescriptorDataCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
