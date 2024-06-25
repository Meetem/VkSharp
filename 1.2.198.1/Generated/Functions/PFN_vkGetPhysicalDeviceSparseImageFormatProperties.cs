using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceSparseImageFormatProperties : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, ref uint, VkSparseImageFormatProperties*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, ref uint, VkSparseImageFormatProperties*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, ref uint, VkSparseImageFormatProperties*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlags, VkImageUsageFlags, VkImageTiling, ref uint, VkSparseImageFormatProperties*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceSparseImageFormatProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceSparseImageFormatProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceSparseImageFormatProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSparseImageFormatProperties(void* v) => new PFN_vkGetPhysicalDeviceSparseImageFormatProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            this.ptr(physicalDevice, format, type, samples, usage, tiling, ref pPropertyCount, pProperties);
        }
    }
}
