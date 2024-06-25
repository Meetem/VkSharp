using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[256];
        public fixed byte description[256];
        public VkBool32 isText;
        public ulong dataSize;
        public void* pData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineExecutableInternalRepresentationKHR Create()
        {
            VkPipelineExecutableInternalRepresentationKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
