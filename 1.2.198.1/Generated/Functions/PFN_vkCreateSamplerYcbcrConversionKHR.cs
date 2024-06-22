using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSamplerYcbcrConversionKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSamplerYcbcrConversionKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSamplerYcbcrConversionKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSamplerYcbcrConversionKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSamplerYcbcrConversionKHR(VkFunctionPointer v) => new PFN_vkCreateSamplerYcbcrConversionKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSamplerYcbcrConversionKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSamplerYcbcrConversionKHR(void* v) => new PFN_vkCreateSamplerYcbcrConversionKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pYcbcrConversion);
        }
    }
}
