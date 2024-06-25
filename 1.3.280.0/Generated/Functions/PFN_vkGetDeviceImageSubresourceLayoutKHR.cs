using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceImageSubresourceLayoutKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageSubresourceInfoKHR, ref VkSubresourceLayout2KHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageSubresourceInfoKHR, ref VkSubresourceLayout2KHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageSubresourceLayoutKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageSubresourceInfoKHR, ref VkSubresourceLayout2KHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageSubresourceLayoutKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageSubresourceInfoKHR, ref VkSubresourceLayout2KHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceImageSubresourceLayoutKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageSubresourceLayoutKHR(VkFunctionPointer v) => new PFN_vkGetDeviceImageSubresourceLayoutKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceImageSubresourceLayoutKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageSubresourceLayoutKHR(void* v) => new PFN_vkGetDeviceImageSubresourceLayoutKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDeviceImageSubresourceInfoKHR pInfo, ref VkSubresourceLayout2KHR pLayout)
        {
            this.ptr(device, in pInfo, ref pLayout);
        }
    }
}
