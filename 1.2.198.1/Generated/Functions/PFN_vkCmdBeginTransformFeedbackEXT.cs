using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBeginTransformFeedbackEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, in ulong, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, in ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBeginTransformFeedbackEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, in ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBeginTransformFeedbackEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBuffer*, in ulong, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBeginTransformFeedbackEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBeginTransformFeedbackEXT(VkFunctionPointer v) => new PFN_vkCmdBeginTransformFeedbackEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBeginTransformFeedbackEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBeginTransformFeedbackEXT(void* v) => new PFN_vkCmdBeginTransformFeedbackEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, in ulong pCounterBufferOffsets)
        {
            this.ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets);
        }
    }
}
