using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAllocationCallbacks
    {
        public void* pUserData;
        public PFN_vkAllocationFunction pfnAllocation;
        public PFN_vkReallocationFunction pfnReallocation;
        public PFN_vkFreeFunction pfnFree;
        public PFN_vkInternalAllocationNotification pfnInternalAllocation;
        public PFN_vkInternalFreeNotification pfnInternalFree;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAllocationCallbacks Create()
        {
            return default;
        }
        
    }
}
