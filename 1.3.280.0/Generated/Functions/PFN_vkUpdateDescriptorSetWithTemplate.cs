using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkUpdateDescriptorSetWithTemplate : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkUpdateDescriptorSetWithTemplate(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkUpdateDescriptorSetWithTemplate(delegate *unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkUpdateDescriptorSetWithTemplate v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkUpdateDescriptorSetWithTemplate(VkFunctionPointer v) => new PFN_vkUpdateDescriptorSetWithTemplate(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkUpdateDescriptorSetWithTemplate v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkUpdateDescriptorSetWithTemplate(void* v) => new PFN_vkUpdateDescriptorSetWithTemplate(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            this.ptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
    }
}
