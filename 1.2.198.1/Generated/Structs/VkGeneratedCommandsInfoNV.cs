using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint sequencesCount;
        public VkBuffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public VkBuffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public VkBuffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGeneratedCommandsInfoNV Create()
        {
            VkGeneratedCommandsInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
