using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdCopyMemoryToImageIndirectNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyMemoryToImageIndirectNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyMemoryToImageIndirectNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdCopyMemoryToImageIndirectNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyMemoryToImageIndirectNV(VkFunctionPointer v) => new PFN_vkCmdCopyMemoryToImageIndirectNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdCopyMemoryToImageIndirectNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyMemoryToImageIndirectNV(void* v) => new PFN_vkCmdCopyMemoryToImageIndirectNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            this.ptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
    }
}
