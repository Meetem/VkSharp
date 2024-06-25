using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdExecuteGeneratedCommandsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBool32, in VkGeneratedCommandsInfoNV, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBool32, in VkGeneratedCommandsInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdExecuteGeneratedCommandsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBool32, in VkGeneratedCommandsInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdExecuteGeneratedCommandsNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBool32, in VkGeneratedCommandsInfoNV, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdExecuteGeneratedCommandsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdExecuteGeneratedCommandsNV(VkFunctionPointer v) => new PFN_vkCmdExecuteGeneratedCommandsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdExecuteGeneratedCommandsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdExecuteGeneratedCommandsNV(void* v) => new PFN_vkCmdExecuteGeneratedCommandsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, in VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
        {
            this.ptr(commandBuffer, isPreprocessed, in pGeneratedCommandsInfo);
        }
    }
}
