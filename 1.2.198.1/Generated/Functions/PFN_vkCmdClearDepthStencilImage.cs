using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdClearDepthStencilImage : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdClearDepthStencilImage(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdClearDepthStencilImage(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdClearDepthStencilImage v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdClearDepthStencilImage(VkFunctionPointer v) => new PFN_vkCmdClearDepthStencilImage(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdClearDepthStencilImage v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdClearDepthStencilImage(void* v) => new PFN_vkCmdClearDepthStencilImage(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, in VkClearDepthStencilValue pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            this.ptr(commandBuffer, image, imageLayout, in pDepthStencil, rangeCount, pRanges);
        }
    }
}
