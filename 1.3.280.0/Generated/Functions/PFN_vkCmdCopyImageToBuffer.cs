using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdCopyImageToBuffer : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyImageToBuffer(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyImageToBuffer(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdCopyImageToBuffer v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyImageToBuffer(VkFunctionPointer v) => new PFN_vkCmdCopyImageToBuffer(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdCopyImageToBuffer v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyImageToBuffer(void* v) => new PFN_vkCmdCopyImageToBuffer(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            this.ptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
    }
}
