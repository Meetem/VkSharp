using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkOpticalFlowImageFormatInfoNV, ref uint, VkOpticalFlowImageFormatPropertiesNV*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkOpticalFlowImageFormatInfoNV, ref uint, VkOpticalFlowImageFormatPropertiesNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkOpticalFlowImageFormatInfoNV, ref uint, VkOpticalFlowImageFormatPropertiesNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkOpticalFlowImageFormatInfoNV, ref uint, VkOpticalFlowImageFormatPropertiesNV*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void* v) => new PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, in VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            return this.ptr(physicalDevice, in pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
        }
    }
}
