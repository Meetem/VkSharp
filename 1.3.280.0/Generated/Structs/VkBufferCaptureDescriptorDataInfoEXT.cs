using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferCaptureDescriptorDataInfoEXT Create()
        {
            VkBufferCaptureDescriptorDataInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
