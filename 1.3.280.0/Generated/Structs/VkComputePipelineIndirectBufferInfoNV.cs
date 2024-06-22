using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkComputePipelineIndirectBufferInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public ulong pipelineDeviceAddressCaptureReplay;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkComputePipelineIndirectBufferInfoNV Create()
        {
            VkComputePipelineIndirectBufferInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
