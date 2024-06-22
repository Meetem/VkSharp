using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroySamplerYcbcrConversion : IVkFuncPtr
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
        public PFN_vkDestroySamplerYcbcrConversion(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroySamplerYcbcrConversion(delegate *unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroySamplerYcbcrConversion v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroySamplerYcbcrConversion(VkFunctionPointer v) => new PFN_vkDestroySamplerYcbcrConversion(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroySamplerYcbcrConversion v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroySamplerYcbcrConversion(void* v) => new PFN_vkDestroySamplerYcbcrConversion(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, ycbcrConversion, in pAllocator);
        }
    }
}