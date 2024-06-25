using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdDrawIndexedIndirectCount : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdDrawIndexedIndirectCount(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdDrawIndexedIndirectCount(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdDrawIndexedIndirectCount v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdDrawIndexedIndirectCount(VkFunctionPointer v) => new PFN_vkCmdDrawIndexedIndirectCount(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdDrawIndexedIndirectCount v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdDrawIndexedIndirectCount(void* v) => new PFN_vkCmdDrawIndexedIndirectCount(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            this.ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
    }
}
