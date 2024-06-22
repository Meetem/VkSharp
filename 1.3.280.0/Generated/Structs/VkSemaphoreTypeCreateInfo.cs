using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreType semaphoreType;
        public ulong initialValue;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSemaphoreTypeCreateInfo Create()
        {
            VkSemaphoreTypeCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
