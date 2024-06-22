using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoSessionMemoryRequirementsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkMemoryRequirements memoryRequirements;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoSessionMemoryRequirementsKHR Create()
        {
            VkVideoSessionMemoryRequirementsKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
