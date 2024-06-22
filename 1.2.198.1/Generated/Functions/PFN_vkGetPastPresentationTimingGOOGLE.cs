using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPastPresentationTimingGOOGLE : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref uint, VkPastPresentationTimingGOOGLE*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref uint, VkPastPresentationTimingGOOGLE*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPastPresentationTimingGOOGLE(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref uint, VkPastPresentationTimingGOOGLE*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPastPresentationTimingGOOGLE(delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref uint, VkPastPresentationTimingGOOGLE*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPastPresentationTimingGOOGLE v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPastPresentationTimingGOOGLE(VkFunctionPointer v) => new PFN_vkGetPastPresentationTimingGOOGLE(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPastPresentationTimingGOOGLE v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPastPresentationTimingGOOGLE(void* v) => new PFN_vkGetPastPresentationTimingGOOGLE(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            return this.ptr(device, swapchain, ref pPresentationTimingCount, pPresentationTimings);
        }
    }
}