using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(void* v) => new PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties)
        {
            this.ptr(physicalDevice, in pExternalSemaphoreInfo, ref pExternalSemaphoreProperties);
        }
    }
}
