using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetLatencyTimingsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkGetLatencyMarkerInfoNV, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkGetLatencyMarkerInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetLatencyTimingsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkGetLatencyMarkerInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetLatencyTimingsNV(delegate *unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, ref VkGetLatencyMarkerInfoNV, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetLatencyTimingsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetLatencyTimingsNV(VkFunctionPointer v) => new PFN_vkGetLatencyTimingsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetLatencyTimingsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetLatencyTimingsNV(void* v) => new PFN_vkGetLatencyTimingsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkSwapchainKHR swapchain, ref VkGetLatencyMarkerInfoNV pLatencyMarkerInfo)
        {
            this.ptr(device, swapchain, ref pLatencyMarkerInfo);
        }
    }
}
