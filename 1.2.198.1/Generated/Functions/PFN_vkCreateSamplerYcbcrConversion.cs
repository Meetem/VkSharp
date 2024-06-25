using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSamplerYcbcrConversion : IVkFuncPtr
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
        public PFN_vkCreateSamplerYcbcrConversion(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSamplerYcbcrConversion(delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerYcbcrConversionCreateInfo, in VkAllocationCallbacks, ref VkSamplerYcbcrConversion, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSamplerYcbcrConversion v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSamplerYcbcrConversion(VkFunctionPointer v) => new PFN_vkCreateSamplerYcbcrConversion(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSamplerYcbcrConversion v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSamplerYcbcrConversion(void* v) => new PFN_vkCreateSamplerYcbcrConversion(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pYcbcrConversion);
        }
    }
}
