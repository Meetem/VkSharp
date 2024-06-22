using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 prefersDedicatedAllocation;
        public VkBool32 requiresDedicatedAllocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryDedicatedRequirements Create()
        {
            VkMemoryDedicatedRequirements ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
