using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDedicatedAllocationImageCreateInfoNV Create()
        {
            VkDedicatedAllocationImageCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
