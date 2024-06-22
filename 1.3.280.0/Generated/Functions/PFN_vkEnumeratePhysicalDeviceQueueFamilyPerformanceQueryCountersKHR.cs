using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkPerformanceCounterKHR*, ref VkPerformanceCounterDescriptionKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkPerformanceCounterKHR*, ref VkPerformanceCounterDescriptionKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkPerformanceCounterKHR*, ref VkPerformanceCounterDescriptionKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkPerformanceCounterKHR*, ref VkPerformanceCounterDescriptionKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkFunctionPointer v) => new PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(void* v) => new PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            return this.ptr(physicalDevice, queueFamilyIndex, ref pCounterCount, pCounters, ref pCounterDescriptions);
        }
    }
}
