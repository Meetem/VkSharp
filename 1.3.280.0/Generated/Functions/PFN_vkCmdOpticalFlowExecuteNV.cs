using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdOpticalFlowExecuteNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, in VkOpticalFlowExecuteInfoNV, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, in VkOpticalFlowExecuteInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdOpticalFlowExecuteNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, in VkOpticalFlowExecuteInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdOpticalFlowExecuteNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, in VkOpticalFlowExecuteInfoNV, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdOpticalFlowExecuteNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdOpticalFlowExecuteNV(VkFunctionPointer v) => new PFN_vkCmdOpticalFlowExecuteNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdOpticalFlowExecuteNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdOpticalFlowExecuteNV(void* v) => new PFN_vkCmdOpticalFlowExecuteNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, in VkOpticalFlowExecuteInfoNV pExecuteInfo)
        {
            this.ptr(commandBuffer, session, in pExecuteInfo);
        }
    }
}
