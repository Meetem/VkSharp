using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkAllocateCommandBuffers : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCommandBufferAllocateInfo, ref VkCommandBuffer, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCommandBufferAllocateInfo, ref VkCommandBuffer, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocateCommandBuffers(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCommandBufferAllocateInfo, ref VkCommandBuffer, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocateCommandBuffers(delegate *unmanaged[Cdecl]<VkDevice, in VkCommandBufferAllocateInfo, ref VkCommandBuffer, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkAllocateCommandBuffers v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocateCommandBuffers(VkFunctionPointer v) => new PFN_vkAllocateCommandBuffers(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkAllocateCommandBuffers v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocateCommandBuffers(void* v) => new PFN_vkAllocateCommandBuffers(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCommandBufferAllocateInfo pAllocateInfo, ref VkCommandBuffer pCommandBuffers)
        {
            return this.ptr(device, in pAllocateInfo, ref pCommandBuffers);
        }
    }
}
