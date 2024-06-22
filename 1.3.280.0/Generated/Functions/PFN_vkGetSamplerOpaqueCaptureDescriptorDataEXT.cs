using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCaptureDescriptorDataInfoEXT, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCaptureDescriptorDataInfoEXT, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCaptureDescriptorDataInfoEXT, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCaptureDescriptorDataInfoEXT, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkFunctionPointer v) => new PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(void* v) => new PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSamplerCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            return this.ptr(device, in pInfo, pData);
        }
    }
}
