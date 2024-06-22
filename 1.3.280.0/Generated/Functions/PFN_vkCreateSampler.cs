using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSampler : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCreateInfo, in VkAllocationCallbacks, ref VkSampler, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCreateInfo, in VkAllocationCallbacks, ref VkSampler, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSampler(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCreateInfo, in VkAllocationCallbacks, ref VkSampler, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSampler(delegate *unmanaged[Cdecl]<VkDevice, in VkSamplerCreateInfo, in VkAllocationCallbacks, ref VkSampler, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSampler v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSampler(VkFunctionPointer v) => new PFN_vkCreateSampler(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSampler v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSampler(void* v) => new PFN_vkCreateSampler(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSamplerCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSampler pSampler)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pSampler);
        }
    }
}
