using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSwapchainKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, ref VkSwapchainKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, ref VkSwapchainKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSwapchainKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, ref VkSwapchainKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSwapchainKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkSwapchainCreateInfoKHR, in VkAllocationCallbacks, ref VkSwapchainKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSwapchainKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSwapchainKHR(VkFunctionPointer v) => new PFN_vkCreateSwapchainKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSwapchainKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSwapchainKHR(void* v) => new PFN_vkCreateSwapchainKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSwapchainCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSwapchainKHR pSwapchain)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pSwapchain);
        }
    }
}
