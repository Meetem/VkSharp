using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSharedSwapchainsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, VkSwapchainKHR*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, VkSwapchainKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSharedSwapchainsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, VkSwapchainKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSharedSwapchainsKHR(delegate *unmanaged[Cdecl]<VkDevice, uint, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, VkSwapchainKHR*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSharedSwapchainsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSharedSwapchainsKHR(VkFunctionPointer v) => new PFN_vkCreateSharedSwapchainsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSharedSwapchainsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSharedSwapchainsKHR(void* v) => new PFN_vkCreateSharedSwapchainsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint swapchainCount, in VkSwapchainCreateInfoKHR pCreateInfos, in VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            return this.ptr(device, swapchainCount, in pCreateInfos, in pAllocator, pSwapchains);
        }
    }
}
