using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdResolveImage2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkResolveImageInfo2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkResolveImageInfo2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdResolveImage2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkResolveImageInfo2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdResolveImage2(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkResolveImageInfo2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdResolveImage2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdResolveImage2(VkFunctionPointer v) => new PFN_vkCmdResolveImage2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdResolveImage2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdResolveImage2(void* v) => new PFN_vkCmdResolveImage2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkResolveImageInfo2 pResolveImageInfo)
        {
            this.ptr(commandBuffer, in pResolveImageInfo);
        }
    }
}