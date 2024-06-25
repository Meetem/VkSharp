using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2, ref uint, VkSparseImageFormatProperties2*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2, ref uint, VkSparseImageFormatProperties2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2, ref uint, VkSparseImageFormatProperties2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2, ref uint, VkSparseImageFormatProperties2*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* v) => new PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, ref uint pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            this.ptr(physicalDevice, in pFormatInfo, ref pPropertyCount, pProperties);
        }
    }
}
