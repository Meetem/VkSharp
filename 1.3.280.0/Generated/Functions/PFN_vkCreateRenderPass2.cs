using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateRenderPass2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo2, in VkAllocationCallbacks, ref VkRenderPass, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo2, in VkAllocationCallbacks, ref VkRenderPass, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRenderPass2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo2, in VkAllocationCallbacks, ref VkRenderPass, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRenderPass2(delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo2, in VkAllocationCallbacks, ref VkRenderPass, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateRenderPass2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRenderPass2(VkFunctionPointer v) => new PFN_vkCreateRenderPass2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateRenderPass2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRenderPass2(void* v) => new PFN_vkCreateRenderPass2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkRenderPassCreateInfo2 pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pRenderPass);
        }
    }
}
