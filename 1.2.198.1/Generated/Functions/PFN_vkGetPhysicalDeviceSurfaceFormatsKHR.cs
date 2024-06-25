using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceSurfaceFormatsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkSurfaceFormatKHR*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkSurfaceFormatKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkSurfaceFormatKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkSurfaceFormatKHR*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceSurfaceFormatsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceSurfaceFormatsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(void* v) => new PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            return this.ptr(physicalDevice, surface, ref pSurfaceFormatCount, pSurfaceFormats);
        }
    }
}
