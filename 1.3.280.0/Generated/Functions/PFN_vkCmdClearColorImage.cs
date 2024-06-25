using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdClearColorImage : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearColorValue, uint, VkImageSubresourceRange*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearColorValue, uint, VkImageSubresourceRange*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdClearColorImage(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearColorValue, uint, VkImageSubresourceRange*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdClearColorImage(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkImage, VkImageLayout, in VkClearColorValue, uint, VkImageSubresourceRange*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdClearColorImage v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdClearColorImage(VkFunctionPointer v) => new PFN_vkCmdClearColorImage(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdClearColorImage v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdClearColorImage(void* v) => new PFN_vkCmdClearColorImage(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, in VkClearColorValue pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            this.ptr(commandBuffer, image, imageLayout, in pColor, rangeCount, pRanges);
        }
    }
}
