using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdEndVideoCodingKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkVideoEndCodingInfoKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkVideoEndCodingInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdEndVideoCodingKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkVideoEndCodingInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdEndVideoCodingKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkVideoEndCodingInfoKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdEndVideoCodingKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdEndVideoCodingKHR(VkFunctionPointer v) => new PFN_vkCmdEndVideoCodingKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdEndVideoCodingKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdEndVideoCodingKHR(void* v) => new PFN_vkCmdEndVideoCodingKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkVideoEndCodingInfoKHR pEndCodingInfo)
        {
            this.ptr(commandBuffer, in pEndCodingInfo);
        }
    }
}
