using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDevicePresentRectanglesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkRect2D*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkRect2D*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDevicePresentRectanglesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkRect2D*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDevicePresentRectanglesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref uint, VkRect2D*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDevicePresentRectanglesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDevicePresentRectanglesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDevicePresentRectanglesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDevicePresentRectanglesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDevicePresentRectanglesKHR(void* v) => new PFN_vkGetPhysicalDevicePresentRectanglesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, VkRect2D* pRects)
        {
            return this.ptr(physicalDevice, surface, ref pRectCount, pRects);
        }
    }
}
