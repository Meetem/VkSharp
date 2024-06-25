using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSetLatencySleepModeNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkLatencySleepModeInfoNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkLatencySleepModeInfoNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetLatencySleepModeNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkLatencySleepModeInfoNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetLatencySleepModeNV(delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkLatencySleepModeInfoNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSetLatencySleepModeNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetLatencySleepModeNV(VkFunctionPointer v) => new PFN_vkSetLatencySleepModeNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSetLatencySleepModeNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetLatencySleepModeNV(void* v) => new PFN_vkSetLatencySleepModeNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkSwapchainKHR swapchain, in VkLatencySleepModeInfoNV pSleepModeInfo)
        {
            return this.ptr(device, swapchain, in pSleepModeInfo);
        }
    }
}
