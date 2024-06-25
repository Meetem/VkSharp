using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdCopyQueryPoolResults : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlags, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyQueryPoolResults(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyQueryPoolResults(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlags, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdCopyQueryPoolResults v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyQueryPoolResults(VkFunctionPointer v) => new PFN_vkCmdCopyQueryPoolResults(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdCopyQueryPoolResults v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyQueryPoolResults(void* v) => new PFN_vkCmdCopyQueryPoolResults(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags)
        {
            this.ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
    }
}
