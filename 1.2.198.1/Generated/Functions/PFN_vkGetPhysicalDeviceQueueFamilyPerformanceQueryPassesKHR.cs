using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkQueryPoolPerformanceCreateInfoKHR, ref uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkQueryPoolPerformanceCreateInfoKHR, ref uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkQueryPoolPerformanceCreateInfoKHR, ref uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkQueryPoolPerformanceCreateInfoKHR, ref uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(void* v) => new PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, ref uint pNumPasses)
        {
            this.ptr(physicalDevice, in pPerformanceQueryCreateInfo, ref pNumPasses);
        }
    }
}
