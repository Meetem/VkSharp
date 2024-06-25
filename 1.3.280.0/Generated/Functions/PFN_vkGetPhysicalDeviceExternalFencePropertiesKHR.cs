using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(void* v) => new PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, ref VkExternalFenceProperties pExternalFenceProperties)
        {
            this.ptr(physicalDevice, in pExternalFenceInfo, ref pExternalFenceProperties);
        }
    }
}
