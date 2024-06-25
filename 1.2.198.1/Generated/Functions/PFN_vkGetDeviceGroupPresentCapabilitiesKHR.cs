using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceGroupPresentCapabilitiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPresentCapabilitiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPresentCapabilitiesKHR(delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceGroupPresentCapabilitiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPresentCapabilitiesKHR(VkFunctionPointer v) => new PFN_vkGetDeviceGroupPresentCapabilitiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceGroupPresentCapabilitiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPresentCapabilitiesKHR(void* v) => new PFN_vkGetDeviceGroupPresentCapabilitiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, ref VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
        {
            return this.ptr(device, ref pDeviceGroupPresentCapabilities);
        }
    }
}
