using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAcquireProfilingLockFlagsKHR flags;
        public ulong timeout;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAcquireProfilingLockInfoKHR Create()
        {
            VkAcquireProfilingLockInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
