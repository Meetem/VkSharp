using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT Create()
        {
            VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
