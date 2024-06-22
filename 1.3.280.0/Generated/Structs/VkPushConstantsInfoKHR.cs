using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPushConstantsInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayout layout;
        public VkShaderStageFlags stageFlags;
        public uint offset;
        public uint size;
        public void* pValues;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPushConstantsInfoKHR Create()
        {
            VkPushConstantsInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
