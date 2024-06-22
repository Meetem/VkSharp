using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR, ref VkVideoEncodeQualityLevelPropertiesKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR, ref VkVideoEncodeQualityLevelPropertiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR, ref VkVideoEncodeQualityLevelPropertiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR, ref VkVideoEncodeQualityLevelPropertiesKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(void* v) => new PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo, ref VkVideoEncodeQualityLevelPropertiesKHR pQualityLevelProperties)
        {
            return this.ptr(physicalDevice, in pQualityLevelInfo, ref pQualityLevelProperties);
        }
    }
}
