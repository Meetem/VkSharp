using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSemaphoreSignalInfo Create()
        {
            VkSemaphoreSignalInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
