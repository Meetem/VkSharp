using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceImageFormatProperties2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceImageFormatProperties2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceImageFormatProperties2(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceImageFormatProperties2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceImageFormatProperties2(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceImageFormatProperties2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceImageFormatProperties2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceImageFormatProperties2(void* v) => new PFN_vkGetPhysicalDeviceImageFormatProperties2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, ref VkImageFormatProperties2 pImageFormatProperties)
        {
            return this.ptr(physicalDevice, in pImageFormatInfo, ref pImageFormatProperties);
        }
    }
}
