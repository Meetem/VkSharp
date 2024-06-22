using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceExternalSemaphoreProperties : IVkFuncPtr
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
        public PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceExternalSemaphoreProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceExternalSemaphoreProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(void* v) => new PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties)
        {
            this.ptr(physicalDevice, in pExternalSemaphoreInfo, ref pExternalSemaphoreProperties);
        }
    }
}
