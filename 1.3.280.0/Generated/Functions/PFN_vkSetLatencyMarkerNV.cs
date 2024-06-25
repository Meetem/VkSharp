using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSetLatencyMarkerNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkSetLatencyMarkerInfoNV, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkSetLatencyMarkerInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetLatencyMarkerNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkSetLatencyMarkerInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetLatencyMarkerNV(delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, in VkSetLatencyMarkerInfoNV, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSetLatencyMarkerNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetLatencyMarkerNV(VkFunctionPointer v) => new PFN_vkSetLatencyMarkerNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSetLatencyMarkerNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetLatencyMarkerNV(void* v) => new PFN_vkSetLatencyMarkerNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkSwapchainKHR swapchain, in VkSetLatencyMarkerInfoNV pLatencyMarkerInfo)
        {
            this.ptr(device, swapchain, in pLatencyMarkerInfo);
        }
    }
}
