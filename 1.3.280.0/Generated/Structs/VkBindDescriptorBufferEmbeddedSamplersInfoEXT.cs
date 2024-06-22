using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindDescriptorBufferEmbeddedSamplersInfoEXT Create()
        {
            VkBindDescriptorBufferEmbeddedSamplersInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
