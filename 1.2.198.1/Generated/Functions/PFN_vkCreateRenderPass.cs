using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateRenderPass : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo, in VkAllocationCallbacks, ref VkRenderPass, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo, in VkAllocationCallbacks, ref VkRenderPass, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRenderPass(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo, in VkAllocationCallbacks, ref VkRenderPass, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRenderPass(delegate *unmanaged[Cdecl]<VkDevice, in VkRenderPassCreateInfo, in VkAllocationCallbacks, ref VkRenderPass, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateRenderPass v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRenderPass(VkFunctionPointer v) => new PFN_vkCreateRenderPass(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateRenderPass v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRenderPass(void* v) => new PFN_vkCreateRenderPass(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkRenderPassCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pRenderPass);
        }
    }
}
