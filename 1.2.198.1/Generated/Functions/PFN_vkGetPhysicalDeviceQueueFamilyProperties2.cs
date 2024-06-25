using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceQueueFamilyProperties2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkQueueFamilyProperties2*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkQueueFamilyProperties2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceQueueFamilyProperties2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkQueueFamilyProperties2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceQueueFamilyProperties2(delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkQueueFamilyProperties2*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceQueueFamilyProperties2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceQueueFamilyProperties2(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceQueueFamilyProperties2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceQueueFamilyProperties2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceQueueFamilyProperties2(void* v) => new PFN_vkGetPhysicalDeviceQueueFamilyProperties2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            this.ptr(physicalDevice, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
    }
}
