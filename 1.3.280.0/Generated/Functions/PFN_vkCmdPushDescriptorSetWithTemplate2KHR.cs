using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdPushDescriptorSetWithTemplate2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkPushDescriptorSetWithTemplateInfoKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkPushDescriptorSetWithTemplateInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdPushDescriptorSetWithTemplate2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkPushDescriptorSetWithTemplateInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdPushDescriptorSetWithTemplate2KHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkPushDescriptorSetWithTemplateInfoKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdPushDescriptorSetWithTemplate2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdPushDescriptorSetWithTemplate2KHR(VkFunctionPointer v) => new PFN_vkCmdPushDescriptorSetWithTemplate2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdPushDescriptorSetWithTemplate2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdPushDescriptorSetWithTemplate2KHR(void* v) => new PFN_vkCmdPushDescriptorSetWithTemplate2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkPushDescriptorSetWithTemplateInfoKHR pPushDescriptorSetWithTemplateInfo)
        {
            this.ptr(commandBuffer, in pPushDescriptorSetWithTemplateInfo);
        }
    }
}
