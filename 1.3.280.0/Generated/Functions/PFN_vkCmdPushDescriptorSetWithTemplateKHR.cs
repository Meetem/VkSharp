using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdPushDescriptorSetWithTemplateKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdPushDescriptorSetWithTemplateKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdPushDescriptorSetWithTemplateKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdPushDescriptorSetWithTemplateKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdPushDescriptorSetWithTemplateKHR(VkFunctionPointer v) => new PFN_vkCmdPushDescriptorSetWithTemplateKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdPushDescriptorSetWithTemplateKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdPushDescriptorSetWithTemplateKHR(void* v) => new PFN_vkCmdPushDescriptorSetWithTemplateKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            this.ptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
    }
}
