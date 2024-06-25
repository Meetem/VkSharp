using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public VkBool32 vertexDynamicStride;
        public VkPipelineLayout pushconstantPipelineLayout;
        public VkShaderStageFlags pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public VkIndirectStateFlagsNV indirectStateFlags;
        public uint indexTypeCount;
        public VkIndexType* pIndexTypes;
        public uint* pIndexTypeValues;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkIndirectCommandsLayoutTokenNV Create()
        {
            VkIndirectCommandsLayoutTokenNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
