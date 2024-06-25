using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetColorBlendEnableEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetColorBlendEnableEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetColorBlendEnableEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkBool32*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetColorBlendEnableEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetColorBlendEnableEXT(VkFunctionPointer v) => new PFN_vkCmdSetColorBlendEnableEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetColorBlendEnableEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetColorBlendEnableEXT(void* v) => new PFN_vkCmdSetColorBlendEnableEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
        {
            this.ptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
    }
}
