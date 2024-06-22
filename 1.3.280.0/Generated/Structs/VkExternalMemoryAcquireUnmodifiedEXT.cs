using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkExternalMemoryAcquireUnmodifiedEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 acquireUnmodifiedMemory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkExternalMemoryAcquireUnmodifiedEXT Create()
        {
            VkExternalMemoryAcquireUnmodifiedEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
