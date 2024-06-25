using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroySamplerYcbcrConversionKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroySamplerYcbcrConversionKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroySamplerYcbcrConversionKHR(delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroySamplerYcbcrConversionKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroySamplerYcbcrConversionKHR(VkFunctionPointer v) => new PFN_vkDestroySamplerYcbcrConversionKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroySamplerYcbcrConversionKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroySamplerYcbcrConversionKHR(void* v) => new PFN_vkDestroySamplerYcbcrConversionKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, ycbcrConversion, in pAllocator);
        }
    }
}
