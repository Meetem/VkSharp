using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetRefreshCycleDurationGOOGLE : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkRefreshCycleDurationGOOGLE, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkRefreshCycleDurationGOOGLE, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRefreshCycleDurationGOOGLE(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkRefreshCycleDurationGOOGLE, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRefreshCycleDurationGOOGLE(delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkRefreshCycleDurationGOOGLE, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetRefreshCycleDurationGOOGLE v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRefreshCycleDurationGOOGLE(VkFunctionPointer v) => new PFN_vkGetRefreshCycleDurationGOOGLE(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetRefreshCycleDurationGOOGLE v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRefreshCycleDurationGOOGLE(void* v) => new PFN_vkGetRefreshCycleDurationGOOGLE(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkSwapchainKHR swapchain, ref VkRefreshCycleDurationGOOGLE pDisplayTimingProperties)
        {
            return this.ptr(device, swapchain, ref pDisplayTimingProperties);
        }
    }
}
