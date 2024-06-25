using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stages;
        public fixed byte name[256];
        public fixed byte description[256];
        public uint subgroupSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineExecutablePropertiesKHR Create()
        {
            VkPipelineExecutablePropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
