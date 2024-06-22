using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateFramebuffer : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkFramebufferCreateInfo, in VkAllocationCallbacks, ref VkFramebuffer, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkFramebufferCreateInfo, in VkAllocationCallbacks, ref VkFramebuffer, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateFramebuffer(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkFramebufferCreateInfo, in VkAllocationCallbacks, ref VkFramebuffer, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateFramebuffer(delegate *unmanaged[Cdecl]<VkDevice, in VkFramebufferCreateInfo, in VkAllocationCallbacks, ref VkFramebuffer, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateFramebuffer v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateFramebuffer(VkFunctionPointer v) => new PFN_vkCreateFramebuffer(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateFramebuffer v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateFramebuffer(void* v) => new PFN_vkCreateFramebuffer(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkFramebufferCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkFramebuffer pFramebuffer)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pFramebuffer);
        }
    }
}
