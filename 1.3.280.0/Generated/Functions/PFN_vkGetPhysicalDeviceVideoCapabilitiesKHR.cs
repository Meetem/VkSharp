using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkVideoProfileInfoKHR, ref VkVideoCapabilitiesKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkVideoProfileInfoKHR, ref VkVideoCapabilitiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkVideoProfileInfoKHR, ref VkVideoCapabilitiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkVideoProfileInfoKHR, ref VkVideoCapabilitiesKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(void* v) => new PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, in VkVideoProfileInfoKHR pVideoProfile, ref VkVideoCapabilitiesKHR pCapabilities)
        {
            return this.ptr(physicalDevice, in pVideoProfile, ref pCapabilities);
        }
    }
}
