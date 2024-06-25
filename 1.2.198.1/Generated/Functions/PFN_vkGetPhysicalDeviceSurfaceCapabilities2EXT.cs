using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref VkSurfaceCapabilities2EXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref VkSurfaceCapabilities2EXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref VkSurfaceCapabilities2EXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, ref VkSurfaceCapabilities2EXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(void* v) => new PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref VkSurfaceCapabilities2EXT pSurfaceCapabilities)
        {
            return this.ptr(physicalDevice, surface, ref pSurfaceCapabilities);
        }
    }
}
